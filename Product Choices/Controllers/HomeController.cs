using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_Choices.Models;
using System.Data.Entity;

namespace Product_Choices.Controllers
{
    public class HomeController : Controller
    {
        public Product_ChoicesContext db = new Product_ChoicesContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string pid)
        {
            if (string.IsNullOrEmpty(pid))
            {
                ModelState.AddModelError("pid", "Please enter the participant id");
            }
            else if (db.Trials.Count(m => m.ParticipantId == pid) != 0)
            {
                ModelState.AddModelError("pid", "The participant id " + pid + " has already been used");
            }
            else
            {
                // Insert trials in random order into database for current pid

                List<Trial> trials = new List<Trial>();

                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 1 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 2 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 3 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 4 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 5 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 6 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 7 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 8 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 9 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 10 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 11 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 12 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 13 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 14 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 15 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 16 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 17 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 18 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 19 });
                db.Trials.Add(new Trial() { ParticipantId = pid, TrialNumber = 20 });
                
                db.SaveChanges();

                return RedirectToAction("Start", new { pid = pid });
            }
            return View();
        }

        public ActionResult Demo(string pid)
        {
            ViewBag.ParticipantId = pid;
            return View();
        }

        public ActionResult Start(string pid)
        {
            ViewBag.ParticipantId = pid;
            return View();
        }

        public ActionResult Practice(string pid)
        {
            var model = new Trial()
            {
                ParticipantId = pid
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Practice(Trial trial)
        {
            return RedirectToAction("Practice2", new { pid=trial.ParticipantId, op=trial.OptionSelected });
        }

        public ActionResult Practice2(string pid, string op)
        {
            ViewBag.Option = op;
            ViewBag.Pid = pid;
            return View();
        }

        public ActionResult Questions1(string pid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questions1(Questions1 results)
        {
            if (ModelState.IsValid)
            {
                db.Questions1.Add(results);
                db.SaveChanges();
                return RedirectToAction("Questions2", new { pid = results.pid });
            }
            return View(results);
        }

        public ActionResult Questions2(string pid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questions2(Questions2 results)
        {
            if (ModelState.IsValid)
            {
                db.Questions2.Add(results);
                db.SaveChanges();
                return RedirectToAction("Complete");
            }
            return View(results);
        }

        public ActionResult Complete()
        {
            return View();
        }
    }
}