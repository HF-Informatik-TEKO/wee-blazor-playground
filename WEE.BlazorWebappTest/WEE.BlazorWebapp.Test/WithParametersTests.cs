using Bunit;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEE.BlazorWebapp.Test;
public class WithParametersTests : TestContext
{
    [Fact]
    public void WithParameters()
    {
        var param = false;
        var text = "Hello World";
        var childContent = "My Cild Content!!";

        var cut = RenderComponent<WithParameters>(p => p
            .Add(e => e.Text, text)
            .Add(e => e.Action, () => param = !param)
            .AddChildContent(childContent)
            );

        Assert.Contains(text, cut.Markup);
        Assert.Contains(childContent, cut.Markup);

        var button = cut.Find("button");
        button.Click();
        //button.Click(detail: 4);
        Assert.True(param);
    }
}
