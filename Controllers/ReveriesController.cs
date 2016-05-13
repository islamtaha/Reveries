using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reveries.Models;

namespace Reveries.Controllers
{
    public class ReveriesController : Controller
    {
        // GET: Reveries
        Context ReverieContext = new Context();

        public ActionResult AddComment(int id, string content)
        {
            Comment comment = new Comment();
            comment.Content = content;
            comment.UserId = ReverieContext.Users.FirstOrDefault().Id;
            comment.ReverieId = id;
            comment.CreateDate = DateTime.Now;
            ReverieContext.Comments.Add(comment);
            ReverieContext.SaveChanges();
            return Content("dsrf");
        }



        public ActionResult EditComment(int id, string content)
        {
            ReverieContext.Comments.FirstOrDefault(a => a.Id == id).Content = content;
            ReverieContext.SaveChanges();
            return Content("dsrf");
        }

        public ActionResult EditReverie(int id, string content)
        {
            ReverieContext.Reveries.FirstOrDefault(a => a.Id == id).Content = content;
            ReverieContext.SaveChanges();
            return Content("dsrf");
        }


        public ActionResult DeleteReverie(int id)
        {
            ReverieContext.Reveries.Remove(ReverieContext.Reveries.FirstOrDefault(a => a.Id == id));
            ReverieContext.SaveChanges();
            return Content("dsrf");
        }



        public ActionResult DeleteComment(int id)
        {
            ReverieContext.Comments.Remove(ReverieContext.Comments.FirstOrDefault(a => a.Id == id));
            ReverieContext.SaveChanges();
            return Content("dsrf");
        }


        public ActionResult Like(int reverieId)
        {
            Like like = new Like();
            like.UserId = ReverieContext.Users.FirstOrDefault().Id;
            like.ReverieId = reverieId;
            ReverieContext.Likes.Add(like);
            ReverieContext.SaveChanges();
            return Content("dsrf");

        }

        public ActionResult Unlike(int reverieId)
        {
            ReverieContext.Likes.Remove(ReverieContext.Likes.FirstOrDefault(a => a.ReverieId == reverieId && a.UserId == ReverieContext.Users.FirstOrDefault().Id));
            ReverieContext.SaveChanges();
            return Content("dsrf");
        }





    }
}