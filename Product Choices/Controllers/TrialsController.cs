using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_Choices.Models;

namespace Product_Choices.Controllers
{
    public class TrialsController : Controller
    {
        public Product_ChoicesContext db = new Product_ChoicesContext();

        // GET: Trials 
        public ActionResult Index(string pid)
        {
            int trialsToGo = db.Trials.Count(n => n.ParticipantId == pid && !n.Completed);

            if (trialsToGo == 0)
            {
                return RedirectToAction("Questions1", "Home", new { pid = pid });
            }

            Random rnd = new Random();
            var firstTrial = db.Trials.Where(m => m.ParticipantId == pid && !m.Completed).ToList().ElementAt(rnd.Next(trialsToGo));            
            return View(firstTrial);
        }

        // POST: Trials
        [HttpPost]
        public ActionResult Index(Trial trial)
        {
            trial.TrialNumber = db.Trials.Count(m => m.ParticipantId == trial.ParticipantId && m.Completed) + 1;
            trial.Completed = true;
            db.Entry(trial).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index", new { pid = trial.ParticipantId});
        }
    }
}