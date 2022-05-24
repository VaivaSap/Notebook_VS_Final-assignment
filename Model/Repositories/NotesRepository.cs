using Notebook_VS_Final_assignment.Areas.Identity.Data;

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
            return _context.Notes.ToList();

        }

        public List<ThoughtSnippets> GetNote(Guid Id)
        {
            return _context.Notes.FirstOrDefault(x => x.Id == Id);
        }

        public void DeleteNotes(Guid Id) // Throwing away an existing note
        {
            var note = _context.Notes.FirstOrDefault(n => n.Id == Id);
            if (note != null)
            {
                _context.Notes.Remove(note);
            }
        }

        public void UpdateNote(Guid Id) // Changing a content of an already existing note
        {
            var note = _context.Notes.FirstOrDefault(n => n.Id == Id);
            var existingNote = GetNote(note.Id);

            if(existingNote != null)
            {
                _context.Notes.Update(note);
                _context.Entry(note).State = Microsoft.EntityFrameworkCore.EntityState.Modified; // (?? pasiaiškinti)
                _context.SaveChanges();
            }

           
        }

        public void Create(ThoughtSnippets note) // Creating a new note 
        {
            _context.Notes.Add(note); // and telling to which table it should be put in
            _context.SaveChanges();
        }

    }
}



