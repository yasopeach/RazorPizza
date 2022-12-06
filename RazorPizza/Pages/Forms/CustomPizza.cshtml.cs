using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Model;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        public float PizzaPrice { get; set; }


        public void OnGet()
        {
        }


        public IActionResult OnPost() // ActionResult, IActionResult, RedirectToPageResult = 3'� de ayn� anlama geliyor.
        {
            PizzaPrice = Pizza.BasePrice;

            PizzaPrice += Pizza.Sauce ? 5 : 0;  // if pizza sauce se�ilmi� ise 5, se�ilmemi� ise pizzaprice'a 0 ekle
            PizzaPrice += Pizza.Cheese ? 5 : 0;
            PizzaPrice += Pizza.Pepperoni ? 5 : 0;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.Name, PizzaPrice } );

        }
    }
}
