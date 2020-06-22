namespace KenBonny.Gambling.App
{
    /// <summary>
    /// This interface exists to give your application a single way to talk to the library
    /// </summary>
    public interface IStakeCalculator
    {
        decimal Calculate(Stake stake);
    }
}