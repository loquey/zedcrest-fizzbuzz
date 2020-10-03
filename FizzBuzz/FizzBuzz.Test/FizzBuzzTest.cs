using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Domain;
using FizzBuzz.Service;
using FizzBuzz.Test.Fixtures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest : IClassFixture<FizzBuzzReturnTypeFixture>
    {
        private IFizzBuzzService _FizzBuzzService;
        private readonly FizzBuzzReturnTypeFixture _ReturnTypes;

        public FizzBuzzTest(FizzBuzzReturnTypeFixture returnTypes)
        {
            _FizzBuzzService = new FizzBuzzService();
            _ReturnTypes = returnTypes;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(93)]
        public void FizzTest(int number)
        {
            Assert.Equal(_ReturnTypes.Fizz, _FizzBuzzService.Process(number));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(70)]
        public void BuzzTest(int number)
        {
            Assert.Equal(_ReturnTypes.Buzz, _FizzBuzzService.Process(number));
        }

        [Theory]
        [InlineData(30)]
        [InlineData(75)]
        public void FizzBuzzCheckTest(int number)
        {
            Assert.Equal(_ReturnTypes.FizzBuzz, _FizzBuzzService.Process(number));
        }

        [Theory]
        [InlineData(34)]
        [InlineData(98)]
        public void NonMatchingNumberTest(int number)
        {
            Assert.Equal(number.ToString(), _FizzBuzzService.Process(number));
        }
    }
}
