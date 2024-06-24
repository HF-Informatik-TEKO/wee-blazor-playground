using AngleSharp.Dom;
using Bunit;
using WEE.BlazorWebappTest.Components.Pages;

namespace WEE.BlazorWebapp.Test;

public class CounterTests : TestContext
{
    [Theory]
    [InlineData(1)]
    [InlineData(20)]
    [InlineData(100)]
    public void AllButtons(int increment)
    {
        var cut = RenderComponent<Counter>(p => p
            .Add(e => e.IncrementAmount, increment)
        );

        var m1 = cut.Markup;

        var buttons = cut.FindAll("button");
        Assert.Equal(3, buttons.Count);

        var addButton = GetElementByName(cut, "button", "add");
        var subButton = GetElementByName(cut, "button", "subtract");

        var initValue = GetCount(cut);

        addButton.Click();
        Assert.Equal(initValue + increment, GetCount(cut));

        subButton.Click();
        Assert.Equal(initValue, GetCount(cut));
    }

    private int GetCount(IRenderedComponent<Counter> cut)
        => GetCount(GetElementByName(cut, "p", "current count:").TextContent);

    private int GetCount(string text)
        => int.Parse(text.Split(": ").Last());

    private IElement GetElementByName(
        IRenderedComponent<Counter> cut,
        string cssIdentifier,
        string name
        )
        => cut
            .FindAll(cssIdentifier)
            .First(e => e.TextContent
                .ToLower()
                .Contains(name.ToLower())
            );
}
