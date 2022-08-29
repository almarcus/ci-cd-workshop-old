using Xunit;

namespace MyUnitTests;

public class UnitTests
{
    int add(int x, int y) => (x+y);

    [Fact]
    public void PassingTest()
    {
        Assert.Equal(5, add(2,3));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(6, add(2,3));
    }

}