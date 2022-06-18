using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewModels;

namespace OnlineStore.ViewComponents
{
    [ViewComponent(Name = "HelloWorldViewComponent")]
    public class HelloWorldViewComponent : ViewComponent
    {
        public HelloWorldViewComponent()
        {


        }

        public async Task<IViewComponentResult> InvokeAsync(string Name)
        {
            HelloWorldViewModel helloWorldViewModel = new HelloWorldViewModel();
            helloWorldViewModel.Greetings = "Welcome " + Name;
            return View(helloWorldViewModel);
        }

    }
}