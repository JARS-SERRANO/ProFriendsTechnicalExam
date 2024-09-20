using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProFriendsApi.Models
{
    public class ProFriendsAPI
    {
        [Key]
        public Double SellingPrice { get; set; }
        public Double ProcessingFee { get; set; }
        public Double ReservationFee { get; set; }
        public DateOnly ReservationDate { get; set; }
        public int EquityTerm { get; set; }
        public int LoanTerm { get; set; }
        public Double InterestRate { get; set; }
        public Double Insurance { get; set; }
    }
}
