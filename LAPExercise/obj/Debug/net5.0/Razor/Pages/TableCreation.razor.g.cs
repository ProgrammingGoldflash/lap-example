#pragma checksum "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\TableCreation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528f7b76f48a985a85c435dc0ffea64ae3729eac"
// <auto-generated/>
#pragma warning disable 1591
namespace LAPExercise.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using LAPExercise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using LAPExercise.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\_Imports.razor"
using LAPExercise.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/database")]
    public partial class TableCreation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TableCreation</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\TableCreation.razor"
        

    protected override void OnInitialized()
    {
        //databaseService.ExecuteWorkflow();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseService databaseService { get; set; }
    }
}
#pragma warning restore 1591