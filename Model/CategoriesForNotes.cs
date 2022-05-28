using Notebook_VS_Final_assignment.Areas.Identity.Data;

namespace Notebook_VS_Final_assignment.Model
{
    public class CategoriesForNotes
    {
        public Guid Id { get; set; }
        public string TitleOfCategory { get; set; }

        public List<ThoughtSnippets> NotesInCategory { get; set; }
       

        public Notebook_User Notebook_User { get; set; }
    }




}
