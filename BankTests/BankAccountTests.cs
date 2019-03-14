using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C0707995_c0709562
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_withValidamount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            account.Debit(debitAmount);

            // Assert 
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
            [TestMethod]
        
        public void Debit_whenAmountIsLessThanZero_ShouldThrowArgumentOutRange()
        {
            //Arrange
            double begnningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr.Brayan waltan", begnningBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeExceptionOfRang e)
            {
                Assert.Fail("The expected exception was not thrown.");
            }
          
            //Assert is handled by the ExpectedException attribute on the test method.
        }
        [TesMethod]

        public void Debit_WhenAmountIMoreThenZero_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double behninningBalance = 11.99;
            double debitAmount = -1000.00;
            BalanceAccount account = new BankAccountTests("Mr.Bryan Walton", beginningBalance);
            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, BankAccountTests.DebitAmountLessThenZeroMessage);
                return;

            }
            Assert.Fail("The expected exception was not thrown.");
            //Assert is handled by the ExpertedException attribute o the test method.
        }
        [TesMethod]

        public void Debit_WhenAmountIMoreThenZero_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double behninningBalance = 11.99;
            double debitAmount = -1000.00;
            BalanceAccount account = new BankAccountTests("Mr.Bryan Walton", beginningBalance);
            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, BankAccountTests.DebitAmountExceedsBalanceMessage);
                return;

            }
            Assert.Fail("The expected exception was not t
    }
}
