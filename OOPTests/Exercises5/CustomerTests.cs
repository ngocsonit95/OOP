using OOP.Exercises5.Enum;
using Xunit;

namespace OOP.Exercises5.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_CustomerTest()
        {
            var actualCustomer = new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913");
            Assert.NotNull(actualCustomer);
        }

        [Fact]
        public void Contructor_CreateObjectNotNull_FullNameTest()
        {
            var customer = new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913");
            var actualFullName = customer.FullName;
            Assert.NotNull(actualFullName);
        }

        [Fact]
        public void Contructor_CreateObjectNotNull_AddressTest()
        {
            var customer = new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913");
            var actualAddress = customer.Address;
            Assert.NotNull(actualAddress);
        }

        [Fact]
        public void Contructor_CreateObjectNotNull_PhoneNumberTest()
        {
            var customer = new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913");
            var actualPhone = customer.PhoneNumber;
            Assert.NotNull(actualPhone);
        }
    }
}