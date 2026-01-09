using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Metadata;
using gesEmpWeb.Models;
using gesEmpWeb.Services;
using System.ComponentModel.Design;

namespace gesEmpWeb.Controllers
{
    public class InscriptionController : Controllers
    {
        private readonly ILogger<InscriptionController> _logger;
        private readonly IAnneeScolaireService _anneeService;
        private readonly IClasseService _classeService;
        private readonly IEtudiantService _etuService;
        private readonly IInscriptionService _inscriptionService;
        public InscriptionController(
            ILogger<InscriptionController> logger,
            IAnneeScolaireService anneeService,
            IClasseService classeService,
            IEtudiantService etuService,
            IInscriptionService inscriptionService
        )
        {
            _logger = logger;
            _anneeService = anneeService;
            _classeService = classeService;
            -etuService = etuService;
            _inscriptionService = inscriptionService;
        }
        [HttpGet]
        public IActionResult List(string codeClasse)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}