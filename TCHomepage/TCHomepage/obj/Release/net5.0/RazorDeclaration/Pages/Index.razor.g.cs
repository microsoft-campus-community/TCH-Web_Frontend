// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TCHomepage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using TCHomepage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\_Imports.razor"
using TCHomepage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\Pages\Index.razor"
using TCHomepage.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "D:\dev\repos\tch-website\TCHomepage\TCHomepage\Pages\Index.razor"
       
    private Speaker[] speakers = Array.Empty<Speaker>();

    protected override async Task OnInitializedAsync()
    {
        await GetSpeaker();
        await InvokeAsync(() =>
        {
            StateHasChanged();
        });

    }

    private async Task GetSpeaker()
    {
        var speakerIDs = await GetSpeakerIDs();
        List<Speaker> speakerList = new List<Speaker>();

        foreach(var id in speakerIDs)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://bems.tc-hamburg.com/api/getSpeakerByID?id=" + id);
            request.Headers.Add("Accept", "application/json");

            var client = new HttpClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                speakerList.Add(JsonSerializer.Deserialize<Speaker>(data));
            }
        }

        speakers = speakerList.ToArray();
    }

    private async Task<string[]> GetSpeakerIDs()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://bems.tc-hamburg.com/api/requestSpeakerIDs");
        request.Headers.Add("Accept", "application/json");

        var client = new HttpClient();
        var response = await client.SendAsync(request);

        string[] id = null;
        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();
            id = JsonSerializer.Deserialize<string[]>(data);
        }

        return id;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
