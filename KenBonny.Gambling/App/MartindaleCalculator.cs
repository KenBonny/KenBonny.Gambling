using KenBonny.Gambling.Library;

namespace KenBonny.Gambling.App
{
    /// <summary>
    /// This class is a facade in front of the actual class that has the implementation
    /// The reason this class exists is to adapt the input and output to what your application needs
    /// </summary>
    public class MartindaleCalculator : IStakeCalculator
    {
        public decimal Calculate(Order order)
        {
            var martindale = new Martindale();
            var input = new Input {MoneyStaked = (decimal) order.Money};
            return martindale.Calculate(input);
        }
    }
}