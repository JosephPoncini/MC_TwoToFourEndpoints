
using MC_TwoToFourEndpoints.WakeUpTime;
namespace MC_TwoToFourEndpoints.Services.WakeUpTime;

public class WakeUpTimeService : IWakeUpTimeService
{
    public string Speak(string name, string time)
    {
        return $"This is {name}, and {name} woke up at {time} today.";
    }
}
