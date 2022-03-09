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
#line 17 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using BlazorWebApp.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\EditData.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\EditData.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\EditData.razor"
using BlazorWebApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\EditData.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployeedetails")]
    public partial class EditData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\EditData.razor"
      

    public List<Employee> Employees { get; set; }

    public List<Department> Departments { get; set; }

    public SfGrid<Employee> employeeGrid { get; set; }

    [Inject]
    public IEmployeeService EmployeeService { get; set; }

    [Inject]
    public IDepartmentService DepartmentService { get; set; }

    public string[] GenderEnumValues = Enum.GetNames(typeof(Gender));

    public string[] pagerDropdown { get; set; } = { "All", "5", "10", "15", "20" };

    public string FooterSaveButtonText { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeService.GetAllEmployees()).ToList();
        Departments = (await DepartmentService.GetAllDepartments()).ToList();
    }

    public string GetDepartmentNameById(int id)
    {
        if(id==0)
        {
            return null;
        }
        else
        {
            return Departments.FirstOrDefault(x => x.DepartmentId == id).DepartmentName;
        }
    }

    public string GetDialogHeader(Employee employee)
    {
        if (employee.EmployeeId == 0)
        {
            FooterSaveButtonText = "Insert";
            return "Add New Employee";
        }
        else
        {
            FooterSaveButtonText = "Update";
            return $"Edit {employee.FirstName} Details";
        }
    }

    public async Task Cancel()
    {
        await employeeGrid.CloseEdit();
    }

    public async Task Save()
    {
        FooterSaveButtonText = "Save";
        await employeeGrid.EndEdit();
    }

    public async Task BatchSaveHandler(BeforeBatchSaveArgs<Employee> Args)
    {
        var updates = Args.BatchChanges.ChangedRecords;
        var inserts = Args.BatchChanges.AddedRecords;
        var deletes = Args.BatchChanges.DeletedRecords;

        foreach (Employee employee in updates)
        {
            await EmployeeService.UpdateEmployee(employee);
        }

        foreach (Employee employee in inserts)
        {
            await EmployeeService.AddEmployee(employee);
        }

        foreach (Employee employee in deletes)
        {
            await EmployeeService.DeleteEmployee(employee.EmployeeId);
        }
    }

    public async void ActionBeginHandler(ActionEventArgs<Employee> Args)
    {
        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
        {
            if (Args.Action == "Add")
            {
                await EmployeeService.AddEmployee(Args.Data);
                Employees = (await EmployeeService.GetAllEmployees()).ToList();
                employeeGrid.Refresh();
            }
            else
            {
                await EmployeeService.UpdateEmployee(Args.Data);
            }
        }
        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Delete))
        {
            await EmployeeService.DeleteEmployee(Args.Data.EmployeeId);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
