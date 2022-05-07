using Microsoft.AspNetCore.Mvc;
using GenFu;
using SimpleWebApi.Models;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ShopController : ControllerBase
{
    private readonly ILogger<ShopController> _logger;

    public ShopController(ILogger<ShopController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "SearchShop")]
    public IEnumerable<SeachShopViewModel> SearchShop(SeachShopViewInput input)
    {
        var data = A.ListOf<SeachShopViewModel>();
        return data.Where(x=>x.shopName.Contains(input.QueryTag));
    }
}
