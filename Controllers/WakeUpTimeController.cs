using MC_TwoToFourEndpoints.WakeUpTime;
using Microsoft.AspNetCore.Mvc;

namespace MC_TwoToFourEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class WakeUpTimeController : ControllerBase
{
    private readonly IWakeUpTimeService _wakeUpTimeService;

    public WakeUpTimeController(IWakeUpTimeService wakeUpTimeService)
    {
        _wakeUpTimeService = wakeUpTimeService;
    }

    [HttpPost]
    [Route("WhatIsYourName/{name}/WhenDidYouWakeUp/{time}")]
    public string Speak(string name, string time){
        return _wakeUpTimeService.Speak(name, time);
    }
}
