// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\RowAnddetail.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\RowAnddetail.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\RowAnddetail.razor"
using BlazorWebApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details")]
    public partial class RowAnddetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\RowAnddetail.razor"
      

    public SfGrid<Employee>
    EmployeeGrid { get; set; }

    public string ToggleButtonContent { get; set; } = "Collapse all detail rows";

    public List<Employee>
        Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
        Employees = (await EmployeeService.GetAllEmployees()).ToList();
        }

        public async void ToggleButtonClick()
        {
        if (ToggleButtonContent.StartsWith("Expand"))
        {
        await EmployeeGrid.ExpandAllDetailRowAsync();
        ToggleButtonContent = "Collapse all detail rows";
        }
        else
        {
        await EmployeeGrid.CollapseAllDetailRowAsync();
        ToggleButtonContent = "Expand all detail rows";
        }
        }

        public async void DataBoundHandler()
        {
        await EmployeeGrid.ExpandAllDetailRowAsync();
        }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591