using System;

namespace KenBonny.Gambling.Library
{
    public class Martindale
    {
        /// <summary>
        /// Do better calculation
        /// </summary>
        public int Calculate(Input input) => (int) Math.Floor(input.MoneyStaked);
    }
}