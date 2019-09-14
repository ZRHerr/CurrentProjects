using QuickFix.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTest
{
    public class ServiceTests
    {
        [Fact]
        public void CanChangeServicesServiceType()
        {
            // Arrange            
            var p = new Services { ServiceType = "Test", BasePrice = 100M };
            // Act            
            p.ServiceType = "New ServiceType";
            //Assert            
            Assert.Equal("New ServiceType", p.ServiceType);
        }
        [Fact]
        public void CanChangeServicesBasePrice()
        {
            // Arrange            
            var p = new Services { ServiceType = "Test", BasePrice = 100M };
            // Act            
            p.BasePrice = 200M;
            //Assert            
            Assert.Equal(200M, p.BasePrice);
        }
    }
}
