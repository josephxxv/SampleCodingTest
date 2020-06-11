namespace Common
{
    public interface IFizzBuzzService
    {
        /// <summary>
        /// FizzBuzz method
        /// </summary>
        /// <param name="input">A positive value to check</param>
        /// <returns>
        /// <paramref name="input"/> is divisible by 3: "Fizz"<br/>
        /// <paramref name="input"/> is divisible by 5: "Buzz"<br/>
        /// <paramref name="input"/> is divisible by both 3 and 5: "FizzBuzz"<br/>
        /// else: <paramref name="input"/>
        /// </returns>
        string GetValue(int input);
    }
}
