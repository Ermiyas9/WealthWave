namespace WealthWave.Test
{
    public class AccountTests
    {
        [Fact]
        public void Account_DepositTransaction_DepositRequestedAmount()
        {
            // Arrange varables, classes mocks
            int amountToDeposit = 100;
            int defaultBalanceOfAccount = 10500;
            int expectedBalanceInBank = 10600;
            string message;
            var userAccount = new Account(defaultBalanceOfAccount);

            // Act
            userAccount.DepositTransaction(amountToDeposit, out message);
            var result = userAccount.CurrentBalance;

            // Assert 
            result.Should().NotBe(null);
            result.Should().Be(expectedBalanceInBank);
            result.Should().BePositive();


        }

        [Fact]
        public void Account_WithdrawTransaction_WithdrawRequestedAmount()
        {
            // Arrange varables, classes mocks
            int amountToWithdraw = 640;
            int defaultBalanceOfAccount = 10600;
            var userAccount = new Account(defaultBalanceOfAccount);
            int expectedBalanceInBank = 9960;
            string message;


            // Act
            userAccount.WithdrawTransaction(amountToWithdraw, out message);
            var result = userAccount.CurrentBalance;

            // Assert 
            result.Should().NotBe(null);
            result.Should().Be(expectedBalanceInBank);
            result.Should().BePositive();


        }


        [Fact]
        public void AccountBoundary_DepositTransaction_DepositRequestedAmount()
        {
            // Arrange varables, classes mocks
            int amountToDeposit = 1000000;
            int defaultBalanceOfAccount = 10500;
            int expectedBalanceInBank = 1010500;
            string message;
            var userAccount = new Account(defaultBalanceOfAccount);

            // Act
            userAccount.DepositTransaction(amountToDeposit, out message);
            var result = userAccount.CurrentBalance;

            // Assert 
            result.Should().NotBe(null);
            result.Should().Be(expectedBalanceInBank);
            result.Should().BePositive();


        }


        [Fact]
        public void AccountBoundary_WithdrawTransaction_WithdrawRequestedAmount()
        {
            // Arrange varables, classes mocks
            int amountToWithdraw = 999999;
            int defaultBalanceOfAccount = 1000000;
            var userAccount = new Account(defaultBalanceOfAccount);
            int expectedBalanceInBank = 1;
            string message;


            // Act
            userAccount.WithdrawTransaction(amountToWithdraw, out message);
            var result = userAccount.CurrentBalance;

            // Assert 
            result.Should().NotBe(null);
            result.Should().Be(expectedBalanceInBank);
            result.Should().BePositive();


        }

        [Fact]
        public void AccountException_DepositTransaction_DepositRequestedAmount()
        {
            // Arrange varables, classes mocks
            int amountToDeposit = -1000000;
            int defaultBalanceOfAccount = 10500;
            int expectedBalanceInBank = -1010500;
            string message;
            var userAccount = new Account(defaultBalanceOfAccount);

            // Act
            userAccount.DepositTransaction(amountToDeposit, out message);
            var result = userAccount.CurrentBalance;

            // Assert 
            result.Should().NotBe(null);
            result.Should().Be(expectedBalanceInBank);
            result.Should().BePositive();


        }


        [Fact]
        public void AccountException_WithdrawTransaction_WithdrawRequestedAmount()
        {
            // Arrange varables, classes mocks
            int amountToWithdraw = 0;
            int defaultBalanceOfAccount = 1000000;
            var userAccount = new Account(defaultBalanceOfAccount);
            int expectedBalanceInBank = 1000000;
            string message;


            // Act
            userAccount.WithdrawTransaction(amountToWithdraw, out message);
            var result = userAccount.CurrentBalance;

            // Assert 
            result.Should().NotBe(null);
            result.Should().Be(expectedBalanceInBank);
            result.Should().BePositive();


        }
    }
}

