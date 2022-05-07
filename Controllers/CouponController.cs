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
    public async Task<List<GetCouponStatusViewModel>> GetCouponStatus(GetCouponStatusViewInput input)
    {
        var data = await _context.Coupons.Where(x => x.status == input.status).AsNoTracking().ToListAsync();

        return _mapper.Map<List<GetCouponStatusViewModel>>(data);
    }

    // [HttpGet("CouponSeed")]
    // public void CouponSeed()
    // {
    //     var data = A.ListOf<Coupon>().Take(10);
    //     foreach(var item in data)
    //     {
    //         _context.Coupons.Add(item);
    //         _context.SaveChanges();
    //     }

    // }
}