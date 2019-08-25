using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsFeed2.Models;

namespace NewsFeed2.Controllers
{
    public class HomeController : Controller
    {

        private List<Article> LoadNews()
        {
            List<Article> news = JSONHelper.LoadJSONFile<List<Article>>("articles.txt");
            return news != null ? news: new List<Article>();
        }

        private void AddArticle(Article article)
        {
            List<Article> news = LoadNews();
            news.Add(article);
            JSONHelper.SaveJSONFile("articles.txt", news);

        }

        public IActionResult Index()
        {
            return View(LoadNews());
        }

        public IActionResult PublishArticle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PublishArticle(Article article)
        {
            article.PublishTime = DateTimeOffset.Now;
            AddArticle(article);

            return Redirect("/");
        }

        public IActionResult Article(long id)
        {
            Article article = LoadNews().FirstOrDefault(x => x.PublishTime.Ticks == id);
            if (article != null)
                return View(article);

            return Index(); 

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
