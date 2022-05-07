using Microsoft.AspNetCore.Mvc;
using GenFu;
using SimpleWebApi.Models;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CouponController : ControllerBase
{
    private readonly ILogger<CouponController> _logger;

    public CouponController(ILogger<CouponController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "GetCouponStatus")]
    public IEnumerable<GetCouponStatusViewModel> GetCouponStatus(GetCouponStatusViewInput input)
    {
        var data = A.ListOf<GetCouponStatusViewModel>();
        return data.Where(x => x.status == input.status);
    }
}