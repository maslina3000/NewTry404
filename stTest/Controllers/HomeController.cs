using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stTest.Models;
using Microsoft.EntityFrameworkCore;

namespace stTest.Controllers
{
    public class HomeController : Controller
    {
        /* private TemplateQuestionary ActiveQuestionary = TemplateQuestionaryPool.Pool[0];
         private static Dictionary<Guid, Questionary> Questionaries = new Dictionary<Guid, Questionary>();
        // private AnswerPool ActiveAnswers = new AnswerPool();
         public ActionResult Index(SomeQuestion someQuestion)
         {
             someQuestion.Text = ActiveQuestionary.Questions[someQuestion.QuestionID].Text;

             return View(someQuestion);
         }

         [HttpPost]
         public ActionResult ProcessQuestionary(SomeQuestion updatedModel, string questionNumber)
         {
             if (questionNumber == "Next")
             {
                 updatedModel.QuestionID++;
             }
             else if (questionNumber == "Last")
             {
                 updatedModel.QuestionID--;
             }

             Questionary questionary;
             if (!Questionaries.TryGetValue(updatedModel.SessionID, out questionary))
             {
                 questionary = new Questionary();
                 Questionaries[updatedModel.SessionID] = questionary;
             }
             updatedModel.Text = ActiveQuestionary.Questions[updatedModel.QuestionID].Text;
             return View("Index", updatedModel);
             // return RedirectToAction("Index");
         }*/
        [HttpPost]
        public ActionResult ProcessQuestionary(SQA updatetModel, string questionNumber )
        {
            if (questionNumber == "Next")
            {
                updatetModel.QuestionId++;
            }
            else if (questionNumber == "Last")
            {
                 updatetModel.QuestionId--;
            }
            
            return View();
        }

        private AnswerContext db;
        public HomeController(AnswerContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Answers.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Answer answer)
        {

            db.Answers.Add(answer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
