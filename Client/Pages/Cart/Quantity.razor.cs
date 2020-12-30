using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace ShoppingCartStarter.Client.Pages.Cart
{
    public class QuantityBase : ComponentBase
    {
        [Parameter] public EventCallback<int> ValueChanged { get; set; }

        [Parameter] public int Value { get; set; }

        protected async Task OnChange(ChangeEventArgs e)
        {
            Value = Convert.ToInt32(e.Value);
            await ValueChanged.InvokeAsync(Value);
        }
    }
}
