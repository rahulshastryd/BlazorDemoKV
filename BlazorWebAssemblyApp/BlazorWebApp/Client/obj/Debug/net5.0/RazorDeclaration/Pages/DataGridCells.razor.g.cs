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
#line 18 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridCells.razor"
using BlazorWebApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridCells.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridCells.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridCells.razor"
using BlazorWebApp.Shared.Utilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagridcells")]
    public partial class DataGridCells : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridCells.razor"
       
    public List<Employee> Employees { get; set; }

    [Inject]
    public IEmployeeService EmployeeService { get; set; }
    public SfGrid<Employee> employeeGrid { get; set; }

    protected void GenderSelectionChange(ChangeEventArgs<string, DropDownListItems> args)
    {
        if (args.Value == "All")
        {
            employeeGrid.ClearFiltering("Gender");
        }
        else
        {
            employeeGrid.FilterByColumn("Gender", "equal", args.Value);
        }
    }

    List<DropDownListItems> genderDorpDownSource = EnumHelper.ConvertEnumToDropDownSource<Gender>("All", "All");

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeService.GetAllEmployees()).ToList();
    }

    private void QueryCellInfoHandler(QueryCellInfoEventArgs<Employee> args)
    {
        if (args.Column.Field == "FirstName")
        {
            if (args.Data.FirstName.StartsWith("S"))
            {
                args.Cell.AddStyle(new string[] { "background-color:purple;color:white" });
            }
            else if (args.Data.FirstName.StartsWith("J"))
            {
                args.Cell.AddStyle(new string[] { "background-color:red;color:white" });
            }
            else
            {
                args.Cell.AddStyle(new string[] { "background-color:yellow;color:white" });
            }
        }
    }

    private void RowBound(RowDataBoundEventArgs<Employee> args)
    {
        if (args.Data.FirstName.StartsWith("S"))
        {
            args.Row.AddStyle(new string[] { "background-color:purple;color:white" });
        }
        else if (args.Data.FirstName.StartsWith("J"))
        {
            args.Row.AddStyle(new string[] { "background-color:red;color:white" });
        }
        else
        {
            args.Row.AddStyle(new string[] { "background-color:yellow;color:white" });
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
