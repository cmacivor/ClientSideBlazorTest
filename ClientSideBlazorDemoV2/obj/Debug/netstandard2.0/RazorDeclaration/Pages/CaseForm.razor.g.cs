#pragma checksum "C:\Users\macivoce\Source\repos\ClientSideBlazorDemoV2\ClientSideBlazorDemoV2\Pages\CaseForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d14a1f6fafa40e4a13bf2eda067b95f371242648"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    using BlazorDemo.Data;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/caseform")]
    public class CaseForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 60 "C:\Users\macivoce\Source\repos\ClientSideBlazorDemoV2\ClientSideBlazorDemoV2\Pages\CaseForm.razor"
            
    List<string> LifecycleEvents { get; set; } = new List<string>();

    List<Offense> offenses;
    private string searchParam;

    private string itemToRemove;

    protected override void OnInit()
    {
        LifecycleEvents.Add("OnInit");
    }

    protected override void OnAfterRender()
    {
        LifecycleEvents.Add("OnAfterRender");
    }

    public async Task<List<Offense>> GetOffensesBySearchString()
    {
        //need to clear the list before we try loading it again, otherwise it will append from previous search
        if (offenses != null && offenses.Any())
        {
            offenses.Clear();
        }

        if (!string.IsNullOrEmpty(searchParam))
        {
            offenses = await OffenseService.GetOffenses();

            offenses = offenses.Where(x => offenses.Any(y => x.Description.ToLower().Contains(searchParam))).ToList();
            searchParam = string.Empty;
        }
        
        return offenses;
    }


    public void RemoveItem(string test)
    {
       var itemToRemove = offenses.FirstOrDefault(x => x.Description == test);

       offenses.Remove(itemToRemove); 
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OffenseService OffenseService { get; set; }
    }
}
#pragma warning restore 1591
