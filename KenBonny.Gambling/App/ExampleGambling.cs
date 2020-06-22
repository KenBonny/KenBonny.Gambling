namespace KenBonny.Gambling.App
{
    public class ExampleGambling
    {
        public void Run()
        {
            var stake = new Order{Money = 5};
            var calculator = CreateCalculator(true);
            calculator.Calculate(stake);
        }

        /// <summary>
        /// This method is a factory method, this can be as complex or simple as needed
        /// This can be a separate class so you can inject dependencies (such as repositories or services)
        /// https://www.tutorialspoint.com/design_pattern/factory_pattern.htm
        /// </summary>
        private IStakeCalculator CreateCalculator(bool isMartindaleNeeded)
        {
            return isMartindaleNeeded
                ? (IStakeCalculator) new MartindaleCalculator()
                : new PercentageOfBankCalculator();
        }
    }
}