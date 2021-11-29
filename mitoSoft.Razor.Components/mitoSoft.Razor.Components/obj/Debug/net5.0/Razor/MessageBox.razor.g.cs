#pragma checksum "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdb61a3802f687f8f3f7331b96c58b877c7cd93"
// <auto-generated/>
#pragma warning disable 1591
namespace mitoSoft.Razor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
using mitoSoft.Razor.Components.Converters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
using mitoSoft.Razor.Components.Enums;

#line default
#line hidden
#nullable disable
    public partial class MessageBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
 if (_show)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display: block;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-dialog modal-dialog-scrollable");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-content");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-header");
            __builder.OpenElement(10, "h4");
#nullable restore
#line 12 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
__builder.AddContent(11, this._title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "data-dismiss", "modal");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
                                                                                        CloseClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "modal-body");
            __builder.OpenElement(22, "p");
#nullable restore
#line 17 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
__builder.AddContent(23, _message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-footer");
#nullable restore
#line 21 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
                     if (_dialogButtons == DialogButtons.OkCancle || _dialogButtons == DialogButtons.YesNo)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
                                                                                 NoClicked

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 23 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
__builder.AddContent(31, _dialogButtons.ToNoText());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
                                                                             YesClicked

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 25 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
__builder.AddContent(36, _dialogButtons.ToYesText());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    <div class=\"modal-backdrop fade show\"></div>");
#nullable restore
#line 31 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\WS_Git\mitoSoft.Razor.Components\mitoSoft.Razor.Components\mitoSoft.Razor.Components\MessageBox.razor"
       
    private bool _show;
    private string _title;
    private string _message;
    private DialogButtons _dialogButtons;

    [Parameter]
    public Action<MouseEventArgs, DialogResult> OnClosed { get; set; }

    public void Show(string title, string message)
    {
        this.Show(title, message, DialogButtons.OK);
    }

    public void Show(string title, string message, DialogButtons buttons)
    {
        _dialogButtons = buttons;
        _title = title;
        _message = message;
        _show = true;
        InvokeAsync(StateHasChanged);
    }

    private void CloseClicked(MouseEventArgs e)
    {
        this.Close();
        this.OnClosed?.Invoke(e, DialogResult.None);
    }

    private void YesClicked(MouseEventArgs e)
    {
        this.Close();
        if (_dialogButtons == DialogButtons.OK
         || _dialogButtons == DialogButtons.OkCancle)
        {
            this.OnClosed?.Invoke(e, DialogResult.OK);
        }
        else if (_dialogButtons == DialogButtons.YesNo)
        {
            this.OnClosed?.Invoke(e, DialogResult.Yes);
        }
        else
        {
            throw new InvalidOperationException($"Invaid DialogButtons '{_dialogButtons}'.");
        }
    }

    private void NoClicked(MouseEventArgs e)
    {
        this.Close();
        if (_dialogButtons == DialogButtons.OkCancle)
        {
            this.OnClosed?.Invoke(e, DialogResult.Cancle);
        }
        else if (_dialogButtons == DialogButtons.YesNo)
        {
            this.OnClosed?.Invoke(e, DialogResult.No);
        }
        else
        {
            throw new InvalidOperationException($"Invaid DialogButtons '{_dialogButtons}'.");
        }
    }

    private void Close()
    {
        _show = false;
        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
