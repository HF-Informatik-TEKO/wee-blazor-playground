using Xunit;
using Bunit;
using WEE.BlazorWebapp.Test;

namespace WEE.BlazorWebapp.Test;

public class HelloWorldTest : TestContext
{
    [Fact]
    public void TestWithInherit()
    {
        // Act
        // cut = component under testing
        var cut = RenderComponent<HelloWorld>();

        // Assert
        cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    }

    [Fact]
    public void TestWithInstance()
    {
        // Arrange
        using var ctx = new TestContext();

        // Act
        var cut = ctx.RenderComponent<HelloWorld>();

        // Assert
        cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    }
}
