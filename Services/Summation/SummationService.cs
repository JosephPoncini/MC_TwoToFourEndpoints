using MC_TwoToFourEndpoints.Summation;

namespace MC_TwoToFourEndpoints.Services.Summation;

public class SummationService : ISummationService
{
    public string Sum(int num1, int num2)
    {
        return $"The sum of {num1} and {num2} is {num1 + num2}.";    
    }
}
