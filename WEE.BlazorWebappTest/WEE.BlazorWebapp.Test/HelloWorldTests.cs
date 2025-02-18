using Bunit;

namespace WEE.BlazorWebapp.Test;

public class HelloWorldTest : TestContext
{
    [Fact]
    public void TestWithInherit()
    {
        // Act
        // cut: Component Under Testing
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
