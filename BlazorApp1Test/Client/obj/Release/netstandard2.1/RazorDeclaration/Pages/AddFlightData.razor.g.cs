#pragma checksum "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\AddFlightData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78639281fa5b2cc3d938d02be0b774ea5e151dad"
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
#line 3 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\AddFlightData.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\AddFlightData.razor"
using BlazorApp1Test.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adddata")]
    public partial class AddFlightData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\AddFlightData.razor"
       
    private HubConnection hubConnection;


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        await hubConnection.StartAsync();
    }

    protected async Task AddRandomFlightData()
    {
        Random rand = new Random();
        GForceParameter gForceParameter = new GForceParameter();

        gForceParameter.AccelX = rand.NextDouble();
        gForceParameter.AccelY = rand.NextDouble();
        gForceParameter.AccelZ = rand.NextDouble();
        gForceParameter.Weight = 2154.000732;

        await Http.PostAsJsonAsync("api/GForceParameters", gForceParameter);
        if (IsConnected) await SendMessage();
        //NavigationManager.NavigateTo("realtime");
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

    //void Cancel()
    //{
    //    NavigationManager.NavigateTo("listbooks");
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
