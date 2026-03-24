using Microsoft.AspNetCore.Mvc;
using MvcNetCoreChollometro.Models;
using System.Threading.Tasks;
using MvcNetCoreChollometro.Repositories;

namespace MvcNetCoreChollometro.Controllers
{
    public class CholloController : Controller
    {
        private RepositoryChollometro repo;

        public CholloController (RepositoryChollometro repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Chollo> chollos = await this.repo.GetChollosAsync();
            return View(chollos);
        }
    }
}
