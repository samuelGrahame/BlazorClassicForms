#pragma checksum "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33f2c24385ebbaab85cd5428294a911b3bff5e3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClassicFormsTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using BlazorClassicFormsTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\_Imports.razor"
using BlazorClassicFormsTest.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Samuel\Source\Repos\BlazorClassicForms\BlazorClassicFormsTest\Shared\MainLayout.razor"
            
    protected override Task OnInitializedAsync()
    {
        BlazorClassicForms.HTML.dom.Setup(IJSRuntime as IJSInProcessRuntime);

        var x = new BlazorClassicFormsTest.UI.frmMain();        
        x.Show();

        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
