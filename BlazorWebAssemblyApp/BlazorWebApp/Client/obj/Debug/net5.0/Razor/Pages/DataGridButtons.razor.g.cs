#pragma checksum "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d95c8b06756f1451638c01fa02fc20000d7165"
// <auto-generated/>
#pragma warning disable 1591
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
#line 18 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
using BlazorWebApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagridbuttons")]
    public partial class DataGridButtons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __Blazor.BlazorWebApp.Client.Pages.DataGridButtons.TypeInference.CreateSfGrid_0(__builder, 1, 2, 
#nullable restore
#line 7 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                             Employees

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 7 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 8 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                       new List<string>() { "Add","Cancel" }

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(6);
                __builder2.AddAttribute(7, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(11);
                __builder2.AddAttribute(12, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                    5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Employee>>(14);
                __builder2.AddAttribute(15, "CommandClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.CommandClickEventArgs<Employee>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.CommandClickEventArgs<Employee>>(this, 
#nullable restore
#line 12 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                    OnCommandClicked

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Employee>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Employee>>(this, 
#nullable restore
#line 12 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                     ActionBeginHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(20);
                    __builder3.AddAttribute(21, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                       nameof(Employee.EmployeeId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "HeaderText", "ID");
                    __builder3.AddAttribute(25, "Width", "60px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(27);
                    __builder3.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                               nameof(Employee.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "HeaderText", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(31);
                    __builder3.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                               nameof(Employee.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "HeaderText", " Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(35);
                    __builder3.AddAttribute(36, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                               nameof(Employee.DateOfBrith)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Format", "d");
                    __builder3.AddAttribute(38, "HeaderText", "Date of Birth");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(40);
                    __builder3.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                               nameof(Employee.Gender)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "HeaderText", "Gender");
                    __builder3.AddAttribute(43, "Width", "140px");
                    __builder3.AddAttribute(44, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<Gender, string>>(45);
                        __builder4.AddAttribute(46, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 22 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                 GenderEnumValues

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Gender>(
#nullable restore
#line 23 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                   (context as Employee).Gender

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Gender>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Gender>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as Employee).Gender = __value, (context as Employee).Gender))));
                        __builder4.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Gender>>>(() => (context as Employee).Gender));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "HeaderText", "Actions");
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumns>(54);
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(56);
                            __builder5.AddAttribute(57, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 29 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                             CommandButtonType.Edit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(58, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 29 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                                     new CommandButtonOptions()
                { IconCss = "e-icons e-edit", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(60);
                            __builder5.AddAttribute(61, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 31 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                             CommandButtonType.Delete

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(62, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 31 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                                       new CommandButtonOptions()
                { IconCss = "e-icons e-delete", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(63, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(64);
                            __builder5.AddAttribute(65, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 33 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                             CommandButtonType.Save

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(66, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 33 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                                     new CommandButtonOptions()
                { IconCss = "e-icons e-update", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(67, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(68);
                            __builder5.AddAttribute(69, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonType>(
#nullable restore
#line 35 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                             CommandButtonType.Cancel

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(70, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 35 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                                                       new CommandButtonOptions()
                { IconCss = "e-icons e-cancel-icon", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(72);
                    __builder3.AddAttribute(73, "HeaderText", "Custom Buttons");
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumns>(75);
                        __builder4.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(77);
                            __builder5.AddAttribute(78, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 41 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                       new CommandButtonOptions() {
                    Content = "U", CssClass = "e-flat" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(79, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Grids.GridCommandColumn>(80);
                            __builder5.AddAttribute(81, "ButtonOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.CommandButtonOptions>(
#nullable restore
#line 43 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                                                       new CommandButtonOptions() {
                    Content = "L", CssClass = "e-round" }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 82, (__value) => {
#nullable restore
#line 7 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
                  employeeGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\DataGridButtons.razor"
      

    public List<Employee> Employees { get; set; }

    public SfGrid<Employee> employeeGrid { get; set; }

    public string[] GenderEnumValues { get; set; } = Enum.GetNames(typeof(Gender));

    [Inject]
    public IEmployeeService EmployeeService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeService.GetAllEmployees()).ToList();
    }

    public void OnCommandClicked(CommandClickEventArgs<Employee> args)
    {
        if (args.CommandColumn.ButtonOption.Content == "U")
        {
            args.RowData.FirstName = args.RowData.FirstName.ToUpper();
            employeeGrid.Refresh();
        }
        else
        {
            args.RowData.FirstName = args.RowData.FirstName.ToLower();
            employeeGrid.Refresh();
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
namespace __Blazor.BlazorWebApp.Client.Pages.DataGridButtons
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "Toolbar", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.AddComponentReferenceCapture(__seq4, (__value) => { __arg4((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
