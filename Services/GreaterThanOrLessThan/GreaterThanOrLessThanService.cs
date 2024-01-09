

using MC_TwoToFourEndpoints.GreaterThanOrLessThan;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MC_TwoToFourEndpoints.Services.GreaterThanOrLessThan
{
    public class GreaterThanOrLessThanService: IGreaterThanOrLessThanService
    {
        public List<string> statements = new();

        public List<string> Compare(int num1, int num2)
        {
            if (num1 > num2)
            {
                statements.Add($"The first number, {num1}, is greater than the second number, {num2}.");
                statements.Add($"The second number, {num2}, is less than the first number, {num1}.");
            }
            else if (num2 > num1)
            {
                statements.Add($"The first number, {num1}, is less than the second number, {num2}.");
                statements.Add($"The second number, {num2}, is greater the first number, {num1}.");
            }else
            {
                statements.Add($"The first number, {num1}, is equal to the second number, {num2}.");
                statements.Add($"The second number, {num2}, is equal to the first number, {num1}.");
            }
            return statements;
        }
    }
}