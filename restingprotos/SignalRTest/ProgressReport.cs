using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace v4demo_simulation_rest.SignalRTest
{
    public class ProgressReport : Hub {
        public async Task UpdataProgress(string user, string message, int percent) {
            await Clients.All.SendAsync("ReceiveMessage", user, message, percent);
        }
    }
}
