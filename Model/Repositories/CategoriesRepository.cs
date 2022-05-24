using Notebook_VS_Final_assignment.Areas.Identity.Data;

namespace Notebook_VS_Final_assignment.Model.Repositories
{
    public class CategoriesRepository
    {

        private readonly ContextNotebook _context;

    
        public CategoriesRepository(ContextNotebook context)
        {
            _context = context;
        }
    }
}
