#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c75d4a6b9a64d733df0186a4b4500df7decc9c0"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class FlightFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "flightFields");
            __builder.AddMarkupContent(2, "<label for=\"flightNumber\">Flight Number</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(3);
            __builder.AddAttribute(4, "id", "flightNumber");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                               Flight.Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.Number = __value, Flight.Number))));
            __builder.AddAttribute(8, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.Number));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.AddMarkupContent(10, "<label for=\"flightDate\">Flight Date</label>\r\n    ");
            __Blazor.FlightManagementBlazorServer.Pages.FlightFields.TypeInference.CreateInputDate_0(__builder, 11, 12, "flightDate", 13, "form-control", 14, 
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                             Flight.FlightDate

#line default
#line hidden
#nullable disable
            , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.FlightDate = __value, Flight.FlightDate)), 16, () => Flight.FlightDate);
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.AddMarkupContent(18, "<label for=\"flightTime\">Flight Time</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
            __builder.AddAttribute(20, "id", "flightTime");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                             Flight.FlightTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.FlightTime = __value, Flight.FlightTime))));
            __builder.AddAttribute(24, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.FlightTime));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.AddMarkupContent(26, "<label for=\"carrier\">Carrier</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
            __builder.AddAttribute(28, "id", "carrier");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                          Flight.Carrier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.Carrier = __value, Flight.Carrier))));
            __builder.AddAttribute(32, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.Carrier));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.AddMarkupContent(34, "<label for=\"airportTo\">Airport To</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
            __builder.AddAttribute(36, "id", "airportTo");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor"
                                            Flight.AirportTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Flight.AirportTo = __value, Flight.AirportTo))));
            __builder.AddAttribute(40, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Flight.AirportTo));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Bojan\Desktop\AirportSystem_Lecture6\FlightManagementBlazorServer\Pages\FlightFields.razor"
       
    [Parameter]
    public Flight Flight { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FlightManagementBlazorServer.Pages.FlightFields
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
