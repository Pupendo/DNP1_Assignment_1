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
#line 2 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\EditAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\EditAdult.razor"
using Assignment1.Persistence;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult/{Id:int}")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\micha\RiderProjects\DNP1\Assignment1\Pages\EditAdult.razor"
       
    private Adult _adult;
    [Parameter]
    public int id { get; set; }
    private string jobTitle { get; set; }
    private int salary { get; set; }

    private void SaveAdult()
    {
        _adult.JobTitle = new Job
        {
            JobTitle = jobTitle,
            Salary = salary
        };
        FileAdapter.Update(_adult);
        NavigationManager.NavigateTo("Adults");
    }

    protected override async Task OnInitializedAsync()
    {
        _adult = FileAdapter.GetAdult(id);
        jobTitle = _adult.JobTitle.JobTitle;
        salary = _adult.JobTitle.Salary;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter FileAdapter { get; set; }
    }
}
#pragma warning restore 1591
