using QuickFix.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace XUnitTest
{
    public class ServiceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
                {GetServicesUnder50()};
            yield return new object[]
                {GetPricesOver50};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private IEnumerable<Services> GetServicesUnder50()
        {
            decimal[] prices = new decimal[]
            {
                275, 49.95M, 19.50M, 24.95M
            };
            for (int i = 0; i < prices.Length; i++)
            {
                yield return new Services
                {
                    ServiceType = $"P{i + 1}",
                    BasePrice = prices[i]
                };
            }
        }
        private Services[] GetPricesOver50 => new Services[]
{
            new Services { ServiceType = "P1", BasePrice = 5 },
            new Services { ServiceType = "P2", BasePrice = 48.95M },
            new Services { ServiceType = "P3", BasePrice = 19.50M },
            new Services { ServiceType = "P4", BasePrice = 24.95M }
};

    }
}
