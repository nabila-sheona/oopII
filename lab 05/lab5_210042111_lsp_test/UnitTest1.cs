using lab5_210042111_lsp;
using System.Security.Principal;

namespace lab5_210042111_lsp_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBalance_current()
        {
            // Arrange
            Current account = new Current(12345, 25000, "nabila", "nabila");

            // Act
            double balance = account.GetBalance();

            // Assert
            Assert.AreEqual(25000, balance);
        }

        [TestMethod]

        public void TestBalance_savings()
        {
            // Arrange

            Account account = new Savings(12345, 25000, "nabila", "nabila");

            // Act
            double balance = account.GetBalance();

            // Assert
            Assert.AreEqual(25000, balance);
        }

        [TestMethod]

        public void Testwithdraw_current()
        {
            Account account = new Current(12345, 25000, "nabila", "nabila");

            //act

            double amount = 600;

            Assert.AreEqual(24400, account.Withdraw(amount));



        }

        public void Testwithdraw_islamic()
        {
            Account account = new Islamic(12345, 25000, "nabila", "nabila");

            //act

            double amount = 600;

            Assert.AreEqual(24400, account.Withdraw(amount));



        }


        [TestMethod]

        public void Testwithdraw_savings()
        {
            Account account = new Savings(12345, 25000, "nabila", "nabila");

            //act

            double amount = 600;

            Assert.AreEqual(24400, account.Withdraw(amount));



        }


        [TestMethod]

        public void Testdeposit_current()
        {
            Account account = new Current(12345, 25000, "nabila", "nabila");

            //act

            double amount = 600;

            Assert.AreEqual(24400, account.Withdraw(amount));



        }

        [TestMethod]

        public void Testdeposit_savings()
        {
            Account account = new Savings(12345, 25000, "nabila", "nabila");

            //act

            double amount = 600;

            Assert.AreEqual(24400, account.Withdraw(amount));



        }

        public void Testdeposit_islamic()
        {
            Account account = new Islamic(12345, 25000, "nabila", "nabila");

            //act

            double amount = 600;

            Assert.AreEqual(24400, account.Withdraw(amount));



        }

        [TestMethod]

        public void Testinterest_current()
        {
            Account account = new Current(12345, 25000, "nabila", "nabila");

            //act

        

            Assert.AreEqual(2000, account.calculateinterest(25000));


        }

        [TestMethod]

        public void Testinterest_savings()
        {
            Account account = new Savings(12345, 25000, "nabila", "nabila");

            //act

            Assert.AreEqual(2500, account.calculateinterest(25000));



        }

        [TestMethod]

        public void Testwithdraw_current_error1()
        {
            Account account = new Current(12345, 25000, "nabila", "nabila");

            //act

            double amount = -60000;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(amount));


        }

        [TestMethod]

        public void Testinterest_islamic()
        {
            Account account = new Islamic(12345, 25000, "nabila", "nabila");

            //act



            Assert.ThrowsException<ArgumentException>(() => account.calculateinterest(25000));

        }

        [TestMethod]

        public void Testwithdraw_savings_error1()
        {
            Account account = new Savings(12345, 25000, "nabila", "nabila");

            //act

            double amount = -60000;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(amount));

        }

        [TestMethod]
        public void TestWithdrawThrowsExceptionWhenBalanceIsInsufficient()
        {
            // Arrange
            Account account = new Current(12345, 25000, "nabila", "nabila");

            double amount = 60000;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(amount));
        }
    

    [TestMethod]

        public void Testwithdraw_savings_error2()
        {
            Account account = new Savings(12345, 25000, "nabila", "nabila");

            double amount = 60000;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(amount));


        }
    }
}