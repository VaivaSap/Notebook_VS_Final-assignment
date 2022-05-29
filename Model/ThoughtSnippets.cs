
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notebook_VS_Final_assignment.Areas.Identity.Data;
using Notebook_VS_Final_assignment.Model.Repositories;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Notebook_VS_Final_assignment.Model
{
    public class ThoughtSnippets
    {

        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }

        public CategoriesForNotes Category { get; set; }




    }

}
