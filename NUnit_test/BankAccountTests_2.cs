using BankAccountNS;
using NUnit.Framework;

namespace BankTests
{
    [TestFixture]
    public class BankAccountTests_2
    {
        [Test]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.That(() => account.Debit(debitAmount),
                Throws.TypeOf<System.ArgumentOutOfRangeException>());
        }

        [Test]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 51.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.That(() => account.Debit(debitAmount),
                Throws.TypeOf<System.ArgumentOutOfRangeException>());
        }
    }
}
