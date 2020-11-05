#pragma checksum "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89835680b93aaa64a6960225e181ec64ad213ad9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1Test.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using BlazorApp1Test.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using BlazorApp1Test.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\Counter.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\Counter.razor"
using BlazorApp1Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\Counter.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\Counter.razor"
       
        GForceParameter[] gForceParameters;
        AttitudeParameter[] attitudeParameters;
    private HubConnection hubConnection;


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/flightDataHub")).Build();

        hubConnection.On("ReceiveMessage", () =>
        {
            CallLoadData();
            StateHasChanged();
        });

        await hubConnection.StartAsync();

        await LoadData();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            await LoadData();
        });
    }

    protected async Task LoadData()
    {
        gForceParameters = await Http.GetFromJsonAsync<GForceParameter[]>("api/GForceParameters");
        attitudeParameters = await Http.GetFromJsonAsync<AttitudeParameter[]>("api/AttitudeParameters");


        StateHasChanged();

    }

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    protected async Task DeleteData(int id)
    {
        await Http.DeleteAsync("api/GForceParameters/" + id);
        if (IsConnected) await SendMessage();
        StateHasChanged();
        //NavigationManager.NavigateTo("listbooks");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
