#pragma checksum "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069bc7c50ae78483043d8522729bed4b52a874fb"
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
#line 2 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
using BlazorWebApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
using BlazorWebApp.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .e-spinner-pane .e-spinner-inner .e-spin-high-contrast .e-path-arc {\r\n        stroke: green;\r\n    }\r\n</style>\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Spinner.SfSpinner>(1);
            __builder.AddAttribute(2, "Label", "Loading Data...Please wait!!!");
            __builder.AddAttribute(3, "Size", "70");
            __builder.AddAttribute(4, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Spinner.SpinnerType>(
#nullable restore
#line 11 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                                                                                 SpinnerType.HighContrast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                          SpinnerVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SpinnerVisible = __value, SpinnerVisible))));
            __builder.CloseComponent();
#nullable restore
#line 13 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
 if (Employees != null)
{

#line default
#line hidden
#nullable disable
            __Blazor.BlazorWebApp.Client.Pages.Index.TypeInference.CreateSfGrid_0(__builder, 7, 8, 
#nullable restore
#line 15 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                     Employees

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 15 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                             true

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 15 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            , 11, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSortSettings>(12);
                __builder2.AddAttribute(13, "AllowUnsort", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridSortColumns>(15);
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridSortColumn>(17);
                        __builder4.AddAttribute(18, "Field", "EmployeeId");
                        __builder4.AddAttribute(19, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SortDirection>(
#nullable restore
#line 18 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                                          SortDirection.Descending

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(21);
                __builder2.AddAttribute(22, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "PageCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                               5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                                                              pagerDropdown

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(28);
                    __builder3.AddAttribute(29, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                           nameof(Employee.EmployeeId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "HeaderText", "Employee ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(32);
                    __builder3.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                           nameof(Employee.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "HeaderText", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(36);
                    __builder3.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                           nameof(Employee.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "HeaderText", " Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(40);
                    __builder3.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
                           nameof(Employee.Email)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "HeaderText", "Email");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 31 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\Rahul\PWA\BlazorDemoKV\BlazorWebAssemblyApp\BlazorWebApp\Client\Pages\Index.razor"
       
    public List<Employee> Employees { get; set; }
    string[] pagerDropdown = new string[] { "All", "5", "10", "15", "20" };

    [Inject]
    public IEmployeeService EmployeeService { get; set; }

    public bool SpinnerVisible { get; set; }

    protected override async Task OnInitializedAsync()
    {
        SpinnerVisible = true;
        await Task.Delay(3000);
        Employees = (await EmployeeService.GetEmployees()).ToList();
        SpinnerVisible = false;
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorWebApp.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowSorting", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
