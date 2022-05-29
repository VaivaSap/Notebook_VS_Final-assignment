using Notebook_VS_Final_assignment.Areas.Identity.Data;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Notebook_VS_Final_assignment.Model.Repositories
{
    public class NotesRepository
    {

        private readonly ContextNotebook _context;
       


        public NotesRepository(ContextNotebook context)
        {
            _context = context;
        }

        public List<ThoughtSnippets> GetNotesOfUser(Guid userId)
        {
            return _context.Categories.Where(c => c.Notebook_User.Id == userId).SelectMany(c => c.NotesInCategory).ToList();

        }

        public ThoughtSnippets GetNote(Guid Id)
        {
            return _context.Notes.FirstOrDefault(x => x.Id == Id);
        }



            

            public void Create(string title, string text, Guid categoryId) // Creating a new note 
            {
                
                var category = _context.Categories.Find(categoryId);
                var note = new ThoughtSnippets


                {
                    Id = Guid.NewGuid(),

                    Title = title,

                    Text = text,

                   Category = category

                };
                _context.Notes.Add(note); // and telling to which table it should be put in
                _context.SaveChanges();
            }


            public void RemoveNote(Guid id)
            {
                var noteToRemove = _context.Notes.FirstOrDefault(n => n.Id == id);
                if (noteToRemove != null)
                {
                    _context.Notes.Remove(noteToRemove);
                    _context.SaveChanges();
                }
            }

            public void EditNote(Guid id, string title, string text)
            {
            var note = _context.Notes.FirstOrDefault(n => n.Id == id);
            note.Title = title;
            note.Text = text;
            _context.SaveChanges();
            }

        

        public List<ThoughtSnippets> GetByTitle(string title, Guid userId) // To find a note by its title
        {
            return _context.Notes.Where(n => n.Title.Contains(title)&& n.Category.Notebook_User.Id == userId).ToList();

        }


        public List<ThoughtSnippets> GetByCategory(string category, Guid userId) 
        {
            return _context.Notes.Where(n => n.Category.TitleOfCategory.Contains(category) && (n.Category.Notebook_User.Id == userId)).ToList();


        }

    }
}




