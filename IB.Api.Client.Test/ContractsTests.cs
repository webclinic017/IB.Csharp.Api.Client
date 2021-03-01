using System;
using IB.Api.Client.Endpoint.Contracts;
using NUnit.Framework;

namespace IB.Api.Client.Test
{
    [TestFixture]
    public class ContractsTests
    {
        ContractEndpoint contractEndpoint;

        [SetUp]
        public void Setup()
        {
            contractEndpoint = new ContractEndpoint();
        }
        [Test]
        public void PrintContractDetails()
        {
            var response = contractEndpoint.ContractSearch("Apple", true);
            Assert.IsNotNull(response);
            foreach (var contract in response)
            {
                Console.WriteLine($"Symbol:{contract.Symbol} ConId:{contract.Conid} CompanyName:{contract.CompanyName}");
            }
        }
    }
}
