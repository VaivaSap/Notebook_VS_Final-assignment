using System.ComponentModel.DataAnnotations.Schema;

namespace Notebook_VS_Final_assignment.Model
{
    public class ThoughtSnippets
    {

        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }

        [ForeignKey("Notebook_User")]
        public Guid UserId { get; set; }




    }
}
