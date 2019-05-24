#pragma checksum "C:\Users\macivoce\Source\repos\ClientSideBlazorDemoV2\ClientSideBlazorDemoV2\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8417b405ba00cb7144ad1a6e863bc7997b3e937c"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientSideBlazorDemoV2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using ClientSideBlazorDemoV2;
    using ClientSideBlazorDemoV2.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Todo (");
            builder.AddContent(2, todos.Count(todo => !todo.IsDone));
            builder.AddContent(3, ")  ");
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n<br>\r\n");
            builder.OpenElement(5, "p");
            builder.AddContent(6, "Machine name:  ");
            builder.AddContent(7, Environment.MachineName);
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n <br>\r\n\r\n");
            builder.OpenElement(9, "ul");
            builder.AddMarkupContent(10, "\r\n");
#line 9 "C:\Users\macivoce\Source\repos\ClientSideBlazorDemoV2\ClientSideBlazorDemoV2\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
            builder.AddContent(11, "        ");
            builder.OpenElement(12, "li");
            builder.AddMarkupContent(13, "\r\n            ");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "type", "checkbox");
            builder.AddAttribute(16, "checked", Microsoft.AspNetCore.Components.BindMethods.GetValue(todo.IsDone));
            builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            builder.CloseElement();
            builder.AddMarkupContent(18, "\r\n            ");
            builder.OpenElement(19, "input");
            builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(todo.Title));
            builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(23, "\r\n");
#line 15 "C:\Users\macivoce\Source\repos\ClientSideBlazorDemoV2\ClientSideBlazorDemoV2\Pages\Todo.razor"
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddMarkupContent(24, "\r\n");
            builder.OpenElement(25, "input");
            builder.AddAttribute(26, "placeholder", "Something todo");
            builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(newTodo));
            builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n");
            builder.OpenElement(30, "button");
            builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, AddTodo));
            builder.AddContent(32, "Add todo");
            builder.CloseElement();
            builder.AddMarkupContent(33, "\r\n<br>\r\n");
            builder.AddMarkupContent(34, "<p>a test change</p>");
        }
        #pragma warning restore 1998
#line 22 "C:\Users\macivoce\Source\repos\ClientSideBlazorDemoV2\ClientSideBlazorDemoV2\Pages\Todo.razor"
            
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo});
            newTodo = string.Empty;
        } 
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
