using System;
using Xunit;
using Integration.ActiveDirectory.Library;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Integration.ActiveDirectory.Testing
{
    public class B2CGraphClient_Tests
    {
        IConfigurationRoot Configuration { get; set; }
        public void SetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.dev.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }


        [Fact]
        public void GetAllUsers__Test()
        {         
            //arrange
            SetConfiguration();
            B2CGraphClient client = new B2CGraphClient(Configuration["b2c:ClientId"], 
                                                       Configuration["b2c:ClientSecret"], 
                                                       Configuration["b2c:Tenant"]);

            //act
            var result = client.GetAllUsers("").Result;


            //assert
            Assert.NotEqual(0, result.Length);  //Will return more all users
        }
    }
}
