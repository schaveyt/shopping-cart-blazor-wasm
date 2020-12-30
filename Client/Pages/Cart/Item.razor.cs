using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ShoppingCartStarter.Shared.Cart;

namespace ShoppingCartStarter.Client.Pages.Cart
{
    public class ItemBase : ComponentBase
    {
        [Parameter]
        public Details.Model.LineItem Details { get; set; }

        [Parameter]
        public EventCallback<Details.Model.LineItem> OnDeleted { get; set; }

        [Inject]
        public HttpClient Http { get; set; }

        protected async Task OnDeleteClicked()
        {
            await Http.DeleteAsync($"api/cart/lines/{Details.Id}");
            await OnDeleted.InvokeAsync(Details);
        }
    }
}