using System;
using Xunit;
using BankLibrary;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1==1);
        }

        [Fact]
        public void NegativeBalanceTest()
        {
            var account = new BankAccount("Salma", 1000);
            Assert.Throws<InvalidOperationException>(
                
                () => account.MakeWithdrawal(1001, DateTime.Now, "Attempt to overdraw")
                
                );
        }

        [Fact]
        public void PositiveInitialBalanceTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("ïnvalid", -7)
                ); 

        }
    }
}
