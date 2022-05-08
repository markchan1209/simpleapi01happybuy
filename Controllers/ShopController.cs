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

    public ShopController(ILogger<ShopController> logger, ApplicationDbContext context, IMapper mapper)
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
    public async Task<ActionResult<SeachShopViewModel>> SearchShop(SeachShopViewInput input)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("請檢查輸入值");
        }
        int Page = input.page;
        int PageSize = input.pageSize;
        int Skipindex = Page * PageSize;
        int Takeindex = PageSize;
        // 自架資料庫不夠大.. 只好用GenFu套件先產生一些資料
        A.Default().ListCount(200);
        var data = A.ListOf<Shop>(200).Where(x => (!string.IsNullOrEmpty(input.QueryTag.Trim()) && x.shopName.Contains(input.QueryTag)));

        //var data = await _context.Shops.Where(x => x.shopName.Contains(input.QueryTag)).AsNoTracking().ToListAsync();
        int TotalCount = data.Count();
        var result = data.Skip(Skipindex).Take(Takeindex);

        SeachShopViewModel model = new SeachShopViewModel()
        {
            TotalCount = TotalCount,
            datas = _mapper.Map<List<SeachShopDetailViewModel>>(result)
        };

        return Ok(model);
    }


}
