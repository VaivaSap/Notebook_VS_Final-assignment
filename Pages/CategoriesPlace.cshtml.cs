using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notebook_VS_Final_assignment.Model;
using Notebook_VS_Final_assignment.Model.Repositories;
using System.Security.Claims;

namespace Notebook_VS_Final_assignment.Pages
{

    [Authorize]
    public class CategoriesPlaceModel : PageModel
    {

        [BindProperty]
        public string Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchInputTitle { get; set; }

        public List<CategoriesForNotes> categoriesForNotes { get; set; } = new List<CategoriesForNotes>();


        private readonly CategoriesRepository _categoriesRepository;

        public CategoriesPlaceModel(CategoriesRepository categoriesRepository)
        {

            _categoriesRepository = categoriesRepository;

        }

        public void OnGet()
        {
            Guid.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out Guid userId);

            categoriesForNotes = _categoriesRepository.GetCategoriesOfUser(userId);

            if (!string.IsNullOrEmpty(SearchInputTitle))
            {

                categoriesForNotes = _categoriesRepository.GetByTitle(SearchInputTitle, userId);


            }

        }
    }

}
