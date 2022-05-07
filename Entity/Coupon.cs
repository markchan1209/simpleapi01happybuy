using SimpleWebApi.Enums;

namespace SimpleWebApi.Entity
{
    public class Coupon
    {
         public int Id { get; set; }

        public string shopName { get; set; }
        public string shopImgUrl { get; set; }

        /// <summary>
        /// 回饋金額
        /// </summary>
        /// <value></value>
        public string rebeat { get; set; }

        public CouponType status { get; set; }
        
    }
}