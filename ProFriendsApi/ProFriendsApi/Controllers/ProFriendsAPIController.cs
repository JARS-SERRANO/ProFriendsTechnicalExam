using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProFriendsApi.Data;
using ProFriendsApi.Models;
using System.Runtime.CompilerServices;

namespace ProFriendsApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProFriendsAPIController : ControllerBase
    {
        private readonly ProfriendsAPIDbContext _context;
        public ProFriendsAPIController(ProfriendsAPIDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<ProFriendsAPI>> Get()
        => await _context.ProFriendsAPI.ToListAsync();

        [HttpGet("SellingPrice")]
        [ProducesResponseType(typeof(ProFriendsAPI), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBySellingPrice(int SellingPrice)
        {
            var var1 = await _context.ProFriendsAPI.FindAsync(SellingPrice);
            return var1 == null ? NotFound() : Ok(SellingPrice);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(ProFriendsAPI proFriendsAPI)
        {
            await _context.ProFriendsAPI.AddAsync(proFriendsAPI);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBySellingPrice), new { id = proFriendsAPI.SellingPrice }, proFriendsAPI);
        }
    }
}
