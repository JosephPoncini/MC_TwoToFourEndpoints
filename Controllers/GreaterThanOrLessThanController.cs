
using MC_TwoToFourEndpoints.GreaterThanOrLessThan;
using MC_TwoToFourEndpoints.Services.GreaterThanOrLessThan;
using Microsoft.AspNetCore.Mvc;

namespace MC_TwoToFourEndpoints.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreaterThanOrLessThanController : ControllerBase
{
    private readonly IGreaterThanOrLessThanService _greaterThanOrLessThanService;

    public GreaterThanOrLessThanController(IGreaterThanOrLessThanService greaterThanOrLessThanService)
    {
        _greaterThanOrLessThanService = greaterThanOrLessThanService;
    }

    [HttpPost]
    [Route("WhichNumberIsGreater/{num1}/Or/{num2}")]
    public List<string> Compare(int num1, int num2)
    {
        return _greaterThanOrLessThanService.Compare(num1, num2);
    }
}
