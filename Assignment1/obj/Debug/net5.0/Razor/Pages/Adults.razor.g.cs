#pragma checksum "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5864625957127c922ff245cdbaa06d7cf7542a"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\micha\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
using Assignment1.Persistence;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List of Adults</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                                                   (arg) => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 150px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, " Filter by minimum age \r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "number");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                                     arg => FilterByAge(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
 if (adultsList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<p><em>Loading...</em></p>");
#nullable restore
#line 18 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
} else if (!adultsList.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>No Adults stored in the system. Please add some.</em></p>");
#nullable restore
#line 23 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.OpenElement(16, "thead");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<th>ID</th>\r\n            ");
            __builder.AddMarkupContent(19, "<th>First Name</th>\r\n            ");
            __builder.AddMarkupContent(20, "<th>Last Name</th>\r\n            ");
            __builder.AddMarkupContent(21, "<th>Sex</th>\r\n            ");
            __builder.AddMarkupContent(22, "<th>Age</th>\r\n            ");
            __builder.AddMarkupContent(23, "<th>Job Title</th>\r\n            ");
            __builder.AddMarkupContent(24, "<th>Height</th>\r\n            ");
            __builder.AddMarkupContent(25, "<th>Weight</th>\r\n            ");
            __builder.AddMarkupContent(26, "<th>Hair Color</th>    \r\n            ");
            __builder.AddMarkupContent(27, "<th>Eye Color</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Policy", "Editor");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(31, "<th>Remove</th>\r\n                ");
                __builder2.AddMarkupContent(32, "<th>Edit</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 47 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
         foreach (var a in AdultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 50 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 51 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 52 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 53 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 54 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "th");
            __builder.AddContent(52, 
#nullable restore
#line 55 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 56 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 57 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 58 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 59 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                     a.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(66);
            __builder.AddAttribute(67, "Policy", "Editor");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(69, "td");
                __builder2.OpenElement(70, "button");
                __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                                            () => RemoveAdult(a.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(72, "<i class=\"oi oi-trash\" style=\"color:#ff0000\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                    \r\n                    ");
                __builder2.OpenElement(74, "td");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
                                            () => Edit(a.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(77, "<i class=\"oi oi-pencil\" style=\"color: #1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\Adults.razor"
       
    private List<Adult> adultsList;
    private string? name;
    private int? minimumAge;
    private IList<Adult> AdultsToShow;

    protected override async Task OnInitializedAsync()
    {
        adultsList = Adapter.GetAdults();
        AdultsToShow = adultsList;
    }

    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        name = null;
        try
        {
            name = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {}
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        AdultsToShow = adultsList.Where(a => (name != null && (a.FirstName.Contains(name) || a.LastName.Contains(name)) || name == null)
                                             && ((minimumAge != null && a.Age >= minimumAge) || minimumAge == null)).ToList();
    }

    private void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        minimumAge = null;
        try
        {
            minimumAge = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void RemoveAdult(int Id)
    {
        Adult adult = adultsList.First(a => a.Id == Id);
        adultsList.Remove(adult);
        AdultsToShow.Remove(adult);
        Adapter.RemoveAdult(adult);
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"EditAdult/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter Adapter { get; set; }
    }
}
#pragma warning restore 1591
