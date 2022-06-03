using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remtask.Context;
using Remtask.Models;
using Remtask.Repositories.Interfaces;
using Remtask.ViewModels;
using System.Diagnostics;

namespace Remtask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITarefaRepository _tarefaRepository;

        public HomeController(ILogger<HomeController> logger, ITarefaRepository tarefaRepository)
        {
            _logger = logger;
            _tarefaRepository = tarefaRepository;
        }

        public IActionResult Index()
        {
            var tarefaViewModel = new TarefaViewModel
            {
                Tarefas = _tarefaRepository.Tarefas.OrderBy(t => t.TarefaId)
             };

            return View(tarefaViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}