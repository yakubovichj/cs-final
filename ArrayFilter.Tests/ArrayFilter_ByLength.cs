using Geekbrains.IT.Final;

namespace Geekbrains.IT.FinalTests;

public class ArrayFilter_ByLength
{
    private readonly ArrayFilter _filter;

    public ArrayFilter_ByLength() {
        _filter = new ArrayFilter();
    }

    [Theory]
    [InlineData(new string[] {"Hello", "2", "world", ":-)"}, new string[] {"2", ":-)"})]
    [InlineData(new string[] {"1234", "1567", "-2", "computer science"}, new string[] {"-2"})]
    [InlineData(new string[] {"Russia", "Denmark", "Kazan"}, new string[] {})]
    public void ByLength_Works(string[] input, string[] expected)
    {
        Assert.Equal<string>(expected, _filter.ByLength(input));        
    }
}