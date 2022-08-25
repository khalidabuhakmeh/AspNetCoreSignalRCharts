using Microsoft.AspNetCore.SignalR;

namespace Charts.Hubs;

public class ChartHub : Hub
{
    public const string Url = "/chart";
}