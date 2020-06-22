using KenBonny.Gambling.Library;

namespace KenBonny.Gambling.App
{
    /// <summary>
    /// This class is a facade in front of the actual class that has the implementation
    /// The reason this class exists is to adapt the input and output to what your application needs
    /// </summary>
    public class PercentageOfBankCalculator : IStakeCalculator
    {
        public decimal Calculate(Order order)
        {
            var percentageOfBank = new PercentageOfBank();
            var input = new Input{MoneyStaked = (decimal) order.Money};
            return percentageOfBank.GetPercentage(input);
        }
    }
}