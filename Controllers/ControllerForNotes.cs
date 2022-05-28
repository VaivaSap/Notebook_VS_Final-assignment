//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Notebook_VS_Final_assignment.Model;
//using Notebook_VS_Final_assignment.Model.Repositories;

//namespace Notebook_VS_Final_assignment.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ControllerForNotes : ControllerBase
//    {
//        private readonly NotesRepository _notesRepository;
//        ControllerForNotes(NotesRepository notesRepository) // Asking not directly but through a repository
//        {
//            _notesRepository = notesRepository;
//        }

       
//        [HttpGet]

//        public List<ThoughtSnippets> Notes()
//        {
//        return  _notesRepository.GetNote();
//        }

//        //[HttpGet("id")]

//        //public ThoughtSnippets GetNote(Guid Id)
//        //{
//        //    return _notesRepository.GetNote(Id);
//        //}

//        //[HttpPost()]
//        //public ActionResult CreateNote(ThoughtSnippets note)
//        //{

//        //}
//    }
//}
