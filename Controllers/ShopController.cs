using Microsoft.AspNetCore.Mvc;
using GenFu;
using SimpleWebApi.Models;
using SimpleWebApi2.Entity;
using SimpleWebApi.Entity;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ShopController : ControllerBase
{
    private readonly ILogger<ShopController> _logger;

    private readonly ApplicationDbContext _context; 

     public readonly IMapper _mapper;

    public ShopController(ILogger<ShopController> logger ,ApplicationDbContext context, IMapper mapper) 
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// 1-2-4 搜尋店家 API
    /// </summary>
    /// <param name="input">QueryTag = 搜尋名稱</param>
    /// <returns></returns>
    [HttpPost("SearchShop")]
    public  async Task<List<SeachShopViewModel>> SearchShop(SeachShopViewInput input)
    {
        var data = await _context.Shops.Where(x => x.shopName.Contains(input.QueryTag)).AsNoTracking().ToListAsync();
        return _mapper.Map<List<SeachShopViewModel>>(data);
    }

    // [HttpGet("SearchShopSeed")]
    // public void SearchShopSeed()
    // {
    //     var data = A.ListOf<Shop>().Take(10);
    //     foreach(var item in data)
    //     {
    //         _context.Shops.Add(item);
    //         _context.SaveChanges();
    //     }
        
    // }
}
