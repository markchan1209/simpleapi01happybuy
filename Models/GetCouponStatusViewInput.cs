using SimpleWebApi.Enums;

namespace SimpleWebApi.Models
{
    public class GetCouponStatusViewInput
    {
        public CouponType status { get; set; }

        public int page { get; set; }

        public int pageSize { get; set; }    
    }
}