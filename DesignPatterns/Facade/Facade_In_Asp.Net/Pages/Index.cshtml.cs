using Application.FacadePattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Facade_In_Asp.Net.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFacadeService _facadeService;
        public IndexModel(ILogger<IndexModel> logger , IFacadeService facadeService)
        {
            _logger = logger;
            _facadeService = facadeService;
        }

        public void OnGet()
        {
            _facadeService.loginService.LoginUser();
        }
    }
}