using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Domain;

namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <inheritdoc/>
        public string Process(int number)
        {
            bool isModulo3 = number % 3 == 0;
            bool isModulo5 = number % 5 == 0;

            return (isModulo3, isModulo5) switch
            {
                (true, true) => "FizzBuzz",
                (true, false) => "Fizz",
                (false, true) => "Buzz",
                _ => number.ToString()
            };
        }
    }
}
