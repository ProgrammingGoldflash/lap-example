// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class MovieSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
       
    private DateTime dateFrom = DateTime.Now;
    private DateTime dateTo = DateTime.Now;

    ICollection<LAPExercise.Data.Models.Movie> Data = new List<LAPExercise.Data.Models.Movie>();

    void Filter()
    {
        Data = database.Movies
            .Include(c => c.Genre)
            .Include(c => c.MovieActors)
                .ThenInclude(c => c.Person)
            .Include(c => c.MovieDirectors)
                .ThenInclude(c => c.Person)
            .Where(c => c.Premiere >= dateFrom && c.Premiere <= dateTo && c.MovieDirectors.Count > 0)
            .OrderBy(c => c.Genre.Name)
            .ThenBy(c => c.Title1)
            .ToList();
        StateHasChanged();
    }

    void TransferData()
    {
        databaseService.ExecuteWorkflow(Data);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseService databaseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LAPExercise.Data.DatabaseContext database { get; set; }
    }
}
#pragma warning restore 1591