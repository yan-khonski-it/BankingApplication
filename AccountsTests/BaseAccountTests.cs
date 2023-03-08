using NUnit.Framework;
using Accounts;

namespace Accounts.Tests
{
    [TestFixture]
    public class BaseAccountsTests
    {
        [Test]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // arrange
            int currentBalance = 10;
            int withdrawal = 1;
            int expected = 9;
            var account = new BaseAccount();
            account.Deposit(currentBalance);

            // act
            account.Withdraw(withdrawal);

            // assert
            Assert.That(account.Balance, Is.EqualTo(expected));
        }

    }
}