using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers.JS
{
    public static class JSInteropExtensions
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            var confirmed = await jSRuntime.InvokeAsync<bool>("confirm", message);

            return confirmed;
        }

        public static async Task Alert(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("alert", message);
        }
    }
}
