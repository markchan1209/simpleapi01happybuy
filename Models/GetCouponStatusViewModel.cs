using SimpleWebApi.Enums;

namespace SimpleWebApi.Models
{
    public class GetCouponStatusViewModel
    {
        public int TotalCount { get; set; }

        public  List<GetCouponStatusDetailViewModel> datas { get; set; }
        
    }
    public class GetCouponStatusDetailViewModel
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