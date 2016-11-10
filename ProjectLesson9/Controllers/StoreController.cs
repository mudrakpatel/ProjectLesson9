using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectLesson9.Models;

namespace ProjectLesson9.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Store
        public ActionResult Index()
        {
            /*
            List<Genre> genres = new List<Genre>
            {
                new Genre("Disco"),
                new Genre("Jazz"),
                new Genre("Rock"),
                new Genre("Electronic")
            }; */

            return View(db.Genres.ToList());
        }

        // GET: Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            if (genre == null)
            {
                genre = "Disco";
            }

            Genre genreModel = new Genre(genre);

            return View(genreModel);
        }

        // GET: Store/Details/5
        public ActionResult Details(int? id = 1)
        {
            Album album = new Album("Album " + id);

            return View(album);
        }
    }
}
