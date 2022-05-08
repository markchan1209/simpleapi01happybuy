using System.ComponentModel.DataAnnotations;
using SimpleWebApi.Enums;

namespace SimpleWebApi.Models
{
    public class GetCouponStatusViewInput
    {
        [Required]
        public CouponType status { get; set; }
        [Required]
        public int page { get; set; }
        [Required]
        public int pageSize { get; set; }    
    }
}