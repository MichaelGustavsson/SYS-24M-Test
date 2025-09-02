namespace BankingSystem.Tests;

public class CustomerTest
{
    [Fact]
    public void ShouldMakesureThatACustomerIsCreatedCorrectlyWithFirstNameAndLastName()
    {
        // Arrange...
        var customer = new Customer("Michael", "Gustavsson");
        // Act...

        // Assert...
        Assert.Equal("Michael", customer.FirstName);
        Assert.Equal("Gustavsson", customer.LastName);
    }

    [Fact]
    public void ShouldReturnFullname()
    {
        // Arrange...
        var customer = new Customer("Michael", "Gustavsson");

        // Act...
        var fullName = customer.FullName;

        // Assert...
        Assert.Equal("Michael Gustavsson", fullName, ignoreCase: true);
    }

    [Fact]
    public void ShouldReturnFullnameWhereFirstNameStartsWith()
    {
        // Arrange...
        var customer = new Customer("Michael", "Gustavsson");

        // Act...
        var firstName = "mi";

        // Assert...
        Assert.StartsWith(firstName.ToUpper(), customer.FullName.ToUpper());
    }

    [Fact]
    public void ShouldReturnFullnameWhereLastNameStartsWith()
    {
        // Arrange...
        var customer = new Customer("Michael", "Gustavsson");

        // Act...

        // Assert...
        Assert.EndsWith("Gustavsson", customer.FullName);
    }

    [Fact]
    public void ShouldReturnFullnameWhereContainsFirstAndLastName()
    {
        // Arrange...
        var customer = new Customer("Michael", "Gustavsson");

        // Act...

        // Assert...
        Assert.Contains("ael Gu", customer.FullName);
    }

    [Fact]
    public void ShouldReturnFullnameWhereFirstAndLastNameDisregardingSpelling()
    {
        // Arrange...
        var customer = new Customer("Michael", "Gustavsson");

        // Act...
        customer.FirstName = "Micael";
        customer.LastName = "Gustafsson";

        // Assert...
        Assert.Matches("Mi(k|c|ch)ael Gusta(v|f)sson", customer.FullName);
    }
}
