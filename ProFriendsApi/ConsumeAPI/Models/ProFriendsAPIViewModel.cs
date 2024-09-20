using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsumeAPI.Models
{
    public class ProFriendsAPIViewModel
    {
        [Key]
        [DisplayName("Selling Price")]
        public Double SellingPrice { get; set; }
        public Double ProcessingFee { get; set; }
        public Double ReservationFee { get; set; }
        public DateOnly ReservationDate { get; set; }
        public Double EquityTerm { get; set; }
        public Double LoanTerm { get; set; }
        public Double InterestRate { get; set; }
        public Double Insurance { get; set; }
    }
}
