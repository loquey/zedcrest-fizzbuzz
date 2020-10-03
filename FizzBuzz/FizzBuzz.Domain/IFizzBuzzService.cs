using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Domain
{
    /// <summary>
    /// FizzBuzzService interface
    /// </summary>
    public interface IFizzBuzzService
    {
        /// <summary>
        /// Returns the string Fizz, Buzz, FizzBuzz or the input number
        /// </summary>
        /// <param name="number">Fizz buzz number</param>
        /// <returns>FizzBuzz equivalence</returns>
        string Process(int number);
    }
}
