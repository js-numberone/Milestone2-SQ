#pragma checksum "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "372333b59f555cb7674d9bbe6fdae216b0dc38c3"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
using BlazorApp1Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/realtime")]
    public partial class FlightDataRealTime : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Flight Data Real Time</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
 if (gForceParameters == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading...</p>\r\n");
#nullable restore
#line 14 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th>Tail #</th>
                <th>Accel-X</th>
                <th>Accel-Y</th>
                <th>Accel-Z</th>
                <th>Weight</th>
                <th>Time Recorded</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 29 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
             foreach (var gParam in gForceParameters)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         gParam.TailNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         gParam.AccelX

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         gParam.AccelY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         gParam.AccelZ

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         gParam.TimeRecorded

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 38 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<thead>\r\n            <tr>\r\n                <th>Altitude</th>\r\n                <th>Pitch</th>\r\n                <th>Bank</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 50 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
             foreach (var aParam in attitudeParameters)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 53 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         aParam.Altitude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 54 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         aParam.Pitch

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 55 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
                         aParam.Bank

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 57 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 60 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\John\Desktop\BlazorApp1Test\BlazorApp1Test\BlazorApp1Test\Client\Pages\FlightDataRealTime.razor"
       
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
