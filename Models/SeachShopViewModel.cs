namespace SimpleWebApi.Models
{
    public class SeachShopViewModel
    {
        public int Id { get; set; }

        public string shopName { get; set; }
        public string shopImgUrl { get; set; }

        public string shopSrc { get; set; }
        /// <summary>
        /// 回饋金額
        /// </summary>
        /// <value></value>
        public string rebeat { get; set; }
        
    }
}