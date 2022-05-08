using System.ComponentModel.DataAnnotations;

namespace SimpleWebApi.Models
{
    public class SeachShopViewInput
    {
        public string QueryTag { get; set; }
        [Required]
        public int page { get; set; }
        [Required]
        public int pageSize { get; set; }    

    }
}