using Xunit;

namespace MyUnitTests;

public class UnitTests
{
    private static int add(int x, int y) => (x+y);

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    [InlineData(0,0,0)]
    public void CanAddTheory(int value1, int value2, int expected)
    {
        Assert.Equal(expected, add(value1,value2));
    }
}