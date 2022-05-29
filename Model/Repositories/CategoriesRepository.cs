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

        public List<CategoriesForNotes> GetCategoriesOfUser(Guid userId)
        {
            return _context.Categories.Where(z => z.Notebook_User.Id == userId).ToList();

        }

        public List<CategoriesForNotes> GetByTitle(string title, Guid userId) // To find a note by its title
        {
            return _context.Categories.Where(n => n.TitleOfCategory.Contains(title) && n.Notebook_User.Id == userId).ToList();

        }


        public CategoriesForNotes GetCategory(Guid Id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == Id);

        }


        public void Create(string title,  Guid userId) 
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);
            var category = new CategoriesForNotes
            {
                Id = Guid.NewGuid(),
                TitleOfCategory = title,
                Notebook_User = user
            };

            _context.Categories.Add(category); 
            _context.SaveChanges();
        }


        public void EditCategory(Guid Id, string title)
        { 
            var category = _context.Categories.FirstOrDefault(n => n.Id == Id);
            category.TitleOfCategory = title;
                _context.SaveChanges();
            }

        


        public void RemoveCategory(Guid Id)
        {
            var categoryToRemove = _context.Categories.FirstOrDefault(c => c.Id == Id);
            if (categoryToRemove != null)
            {
                _context.Categories.Remove(categoryToRemove);
                _context.SaveChanges();
            }
        }

     
    }


    
}
