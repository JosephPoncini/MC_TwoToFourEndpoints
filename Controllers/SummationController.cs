using MC_TwoToFourEndpoints.Summation;
using Microsoft.AspNetCore.Mvc;

namespace MC_TwoToFourEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class SummationController : ControllerBase
{
    private readonly ISummationService _summationService;

    public SummationController(ISummationService summationService)
    {
        _summationService = summationService;
    }

    [HttpPost]
    [Route("WhatIsTheSumOf/{num1}/and/{num2}")]

    public string Sum(int num1, int num2){
        return _summationService.Sum(num1, num2);
    }
}
