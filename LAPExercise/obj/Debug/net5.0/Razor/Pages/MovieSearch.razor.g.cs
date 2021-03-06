#pragma checksum "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3462dd9d3b4f77307d49a1f95365ef5c074f09d9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class MovieSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Filmsuche</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5>Suche nach Filmen in einem bestimmten Zeitraum</h5>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col\">\r\n        Zeitraum:\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col");
            __builder.OpenComponent<Blazorise.DateEdit<DateTime>>(7);
            __builder.AddAttribute(8, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime>(
#nullable restore
#line 14 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                                 dateFrom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dateFrom = __value, dateFrom))));
            __builder.AddAttribute(10, "DateExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<DateTime>>>(() => dateFrom));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col");
            __builder.OpenComponent<Blazorise.DateEdit<DateTime>>(14);
            __builder.AddAttribute(15, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime>(
#nullable restore
#line 17 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                                 dateTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dateTo = __value, dateTo))));
            __builder.AddAttribute(17, "DateExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<DateTime>>>(() => dateTo));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col");
            __builder.OpenComponent<Blazorise.Button>(23);
            __builder.AddAttribute(24, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                          Filter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "suche");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col");
            __builder.OpenComponent<Blazorise.Table>(32);
            __builder.AddAttribute(33, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(37);
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(39);
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(41, "Genre");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(43);
                        __builder4.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(45, "Filmtitel");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(47);
                        __builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(49, "Jahr");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(51);
                        __builder4.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(53, "Regie");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n\r\n            ");
                __builder2.OpenComponent<Blazorise.TableBody>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 40 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                 foreach (var x in Data)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(57);
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowCell>(59);
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(61, 
#nullable restore
#line 43 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                       x.Genre.Name

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(62, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(63);
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(65, 
#nullable restore
#line 44 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                       x.Title1

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(66, " ");
                            __builder5.AddContent(67, 
#nullable restore
#line 44 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                                 x.Title2

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(68, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(69);
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(71, 
#nullable restore
#line 45 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                       x.Premiere.Year

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(73);
                        __builder4.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 47 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                              
                                var first = true;
                                foreach (var person in x.MovieDirectors)
                                {
                                    if (first)
                                        first = false;
                                    else
                                    {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(75, ", ");
#nullable restore
#line 55 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                                       
                                    }

                                    

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(76, 
#nullable restore
#line 58 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                     person.Person.FirstName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(77, 
#nullable restore
#line 58 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                                              person.Person.LastName

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 58 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                                                                                    
                                }
                            

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 63 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "row");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col");
            __builder.OpenComponent<Blazorise.Button>(83);
            __builder.AddAttribute(84, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 71 "D:\Projects\Berufsschule\LAPExercise\LAPExercise\Pages\MovieSearch.razor"
                          TransferData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(86, "Daten übertragen");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
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
