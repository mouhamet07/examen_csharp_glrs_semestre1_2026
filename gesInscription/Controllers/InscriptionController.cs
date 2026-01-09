using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Metadata;
using gesInscription.Models;
using gesInscription.Services;
using System.ComponentModel.Design;

namespace gesInscription.Controllers
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
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etudiants = _etudiantService.GetEtudiants();
            ViewBag.Classes = _classeService.GetClasses();
            ViewBag.Annees = _anneeService.GetAnneeScolaires();
            return View();
        }
        [HttpPost]
        public IActionResult Create(int etudiantId, int classeId, int anneeId, decimal montant)
        {
            var inscription = new Inscription();
            inscription.EtudiantId = etudiantId;
            inscription.ClasseId = classeId;
            inscription.AnneeScolaireId = anneeId;
            inscription.Montant = montant;
            _inscriptionService.CreateInscription(inscription);
            return View();
        }
    }
}