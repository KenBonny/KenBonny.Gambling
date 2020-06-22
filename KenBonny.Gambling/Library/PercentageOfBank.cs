namespace KenBonny.Gambling.Library
{
    public class PercentageOfBank
    {
        /// <summary>
        /// Do better calculation
        /// </summary>
        public decimal GetPercentage(Input input) => input.MoneyStaked / 100;
    }
}