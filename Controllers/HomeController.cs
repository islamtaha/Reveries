using Reveries.Models;
using Reveries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reveries.Controllers
{
    [OverrideAuthentication]
    public class HomeController : Controller
    {
        Context context = new Context();


        public ActionResult Index()
        {
            var xs = context.Users.FirstOrDefault().Follower;
            List<Reverie> r = new List<Reverie>();
            foreach (var x in xs)
            {
                r.AddRange(x.Follower.Reveries);
            }
            return View(new HomeIndex {
                reveries = r.Take(8).ToList()
            });
        }

        [HttpPost]
        public ActionResult HomeReveries(int skip)
        {
            var xs = context.Users.FirstOrDefault().Follower;
            List<Reverie> r = new List<Reverie>();
            foreach (var x in xs)
            {
                r.AddRange(x.Follower.Reveries);
            }
            return View(new HomeHomeReveries
            {
                reveries = r.OrderByDescending(a => a.Id).Skip(skip).Take(8).ToList()
            });

        }


        [HttpPost]
        public ActionResult Search(string username)
        {
            if (String.IsNullOrEmpty(username))
              return  RedirectToRoute("Home");
            return View(new HomeSearch {
                Users = context.Users.Where(a => a.Username.Contains(username) || a.Name.Contains(username)).OrderBy(a => a.Id).Take(9).ToList()
            });
        }

        [HttpPost]
        public ActionResult SearchCards(string username , int skip )
        {
            return View(new HomeSearchCards
            {
                Users = context.Users.Where(a => a.Username.Contains(username) || a.Name.Contains(username)).OrderBy(a => a.Id).Skip(skip).Take(9).ToList()
            });
        }



        [HttpPost]
        public ActionResult Index(HomeIndex home)
        {
            string reverie = home.textArea;
            if (String.IsNullOrEmpty(reverie))
                return RedirectToRoute("Home");
            else
            {
                Reverie reverieObj = new Reverie();
                reverieObj.Content = reverie;
                reverieObj.CreateDate = DateTime.Now;
                reverieObj.User = context.Users.ToList().FirstOrDefault();
                context.Reveries.Add(reverieObj);
                context.SaveChanges();
                return RedirectToRoute("Home");
            }
        }


    }
}