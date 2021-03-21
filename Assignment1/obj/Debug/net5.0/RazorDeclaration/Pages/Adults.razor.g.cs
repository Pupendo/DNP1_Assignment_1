// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
