using System;
using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzIntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _Factory;

        public FizzBuzzIntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _Factory = factory;
        }

        [Theory]
        [InlineData("/api/FizzBuzz/0")]
        [InlineData("/api/FizzBuzz/101")]
        [InlineData("/api/FizzBuzz/-10")]
        public async void Get_EndpoinReturnsBadsRequest(string url)
        {
            var client = _Factory.CreateClient();

            var response = await client.GetAsync(url);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory]
        [InlineData("/api/FizzBuzz/30")]
        public async void Get_EndpointRetunsOk(string url)
        {
            var client = _Factory.CreateClient();

            var response = await client.GetAsync(url);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
