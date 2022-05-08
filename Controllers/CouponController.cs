using Microsoft.AspNetCore.Mvc;
using GenFu;
using SimpleWebApi.Models;
using SimpleWebApi.Entity;
using SimpleWebApi2.Entity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CouponController : ControllerBase
{
    private readonly ILogger<CouponController> _logger;
    private readonly ApplicationDbContext _context;
    public readonly IMapper _mapper;
    public CouponController(ILogger<CouponController> logger, ApplicationDbContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// 1-4 發票回饋查詢 API
    /// </summary>
    /// <param name="input">status 0 (領取中) 1 (處理中) 2 (領取完成)</param>
    /// <returns></returns>
    [HttpPost("GetCouponStatus")]
    public async Task<GetCouponStatusViewModel> GetCouponStatus(GetCouponStatusViewInput input)
    {
        int Page = input.page;
        int PageSize = input.pageSize;
        int Skipindex = Page * PageSize;
        int Takeindex = PageSize;
        // 自架資料庫不夠大.. 只好用GenFu套件先產生一些資料
        A.Default().ListCount(200);
        var data = A.ListOf<Coupon>(200).Where(x => x.status == input.status);
        //var data = await _context.Coupons.Where(x => x.status == input.status).AsNoTracking().ToListAsync();
         
        int TotalCount = data.Count();
        var result = data.Skip(Skipindex).Take(Takeindex);

        GetCouponStatusViewModel model = new GetCouponStatusViewModel()
        {
            TotalCount = TotalCount,
            datas = _mapper.Map<List<GetCouponStatusDetailViewModel>>(result)
        };

        return model;
    }

    
}