#pragma checksum "E:\Jatin work\blazor-server-crud\blazor-server-crud\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a02bb46358323d602228beecd78f63de46fea0"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_server_crud.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using blazor_server_crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using blazor_server_crud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using blazor_server_crud.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using blazor_server_crud.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Jatin work\blazor-server-crud\blazor-server-crud\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-0a7hm32daf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-0a7hm32daf");
            __builder.OpenComponent<blazor_server_crud.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-0a7hm32daf");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-0a7hm32daf><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-0a7hm32daf>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-0a7hm32daf");
            __builder.AddContent(15, 
#nullable restore
#line 14 "E:\Jatin work\blazor-server-crud\blazor-server-crud\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
