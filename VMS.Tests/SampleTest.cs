using Xunit;  // ← ADD THIS

public class SampleTest
{
    [Fact]
    public void TwoPlus2_ShouldBe4()
    {
        var result = 2 + 2;
        Assert.Equal(4, result);
    }

    [Fact]
    public void List_ShouldContainItems()
    {
        var items = new List<string> { "Vehicle1", "Vehicle2" };
        Assert.NotEmpty(items);
    }
}