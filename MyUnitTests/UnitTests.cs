using Xunit;
using Services;

namespace MyUnitTests;

public class UnitTests
{
    private static int add(int x, int y) => (x+y);

    [Fact]
    public void CapitalizedNameReturnsCorrectly(){
        string message = Services.UserService.GreetUser("Aaron");

        Assert.Equal("Welcome, Aaron!", message);
    }

    [Fact]
    public void UppercaseNameReturnsCorrectly(){
        string message = Services.UserService.GreetUser("AARON");

        Assert.Equal("Welcome, Aaron!", message);
    }

    [Fact]
    public void LowercaseNameReturnsCorrectly(){
        string message = Services.UserService.GreetUser("aaron");

        Assert.Equal("Welcome, Aaron!", message);
    }

    [Fact]
    public void NullNameReturnsCorrectly(){
        string message = Services.UserService.GreetUser(null);

        Assert.Equal("Who are you?", message);    
    }

    [Fact]
    public void EmptyNameReturnsCorrectly(){
        string message = Services.UserService.GreetUser("");

        Assert.Equal("Who are you?", message);    
    }

    [Fact]
    public void BlankNameReturnsCorrectly(){
        string message = Services.UserService.GreetUser("        ");

        Assert.Equal("Who are you?", message);    
    }

    [Fact]
    public void AlwaysPasses(){
        Assert.True(true);
    }

    [Fact]
    public void AlwaysFails(){
        Assert.False(true);
    }
}