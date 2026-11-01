using Microsoft.AspNetCore.Mvc;
using RhynoPerformance.Models;

namespace RhynoPerformance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new LandingViewModel
            {
                Planes = new List<PlanViewModel>
                {
                    new() { Nombre = "Plan Básico", Precio = 26000, Periodo = "/mes", ColorBadge = "cyan",
                            Beneficios = {
                                "Área de gimnasio (biomecánica) y cardio",
                                "Uso de máquinas sin límite",
                                "Rutina personalizada que se renueva cada 8 semanas",
                                "Clases de Cardio Dance y Cardio Step" } },

                    new() { Nombre = "Plan Premium", Precio = 30000, Periodo = "/mes", ColorBadge = "orange", Destacado = true,
                            Beneficios = {
                                "Acceso a todas las clases",
                                "Funcionales, Hyrox y Cross",
                                "Cardio Dance y Cardio Step",
                                "Área de gimnasio en todo su horario" } },

                    new() { Nombre = "Menores de edad", Precio = 23500, Periodo = "/mes", ColorBadge = "purple",
                            Nota = "Presentar cédula al ingresar",
                            Beneficios = {
                                "Mismos beneficios del Plan Básico",
                                "Gimnasio, Cardio Dance y Cardio Step",
                                "Rutina personalizada cada 8 semanas" } }
                },

                Clases = new List<ClaseViewModel>
                {
                    new() { Nombre = "Gimnasio", Color = "cyan",
                            Horarios = { "Lunes a viernes · 5:00 a.m. – 9:00 p.m.", "Sábado · 8:00 a.m. – 3:00 p.m.", "Domingo · 8:00 a.m. – 1:00 p.m." } },
                    new() { Nombre = "Funcionales", Color = "orange", SoloPremium = true,
                            Horarios = { "Lunes, miércoles y viernes · 7:00 a.m.", "Lunes, miércoles y viernes · 5:00 p.m." } },
                    new() { Nombre = "Cross", Color = "orange", SoloPremium = true,
                            Horarios = { "Lunes y miércoles · 7:00 p.m.", "Martes, jueves y viernes · 6:30 p.m.", "Sábado · 10:00 a.m.", "Domingo · libre" } },
                    new() { Nombre = "Hyrox", Color = "yellow", SoloPremium = true,
                            Horarios = { "Martes y jueves · 7:30 p.m.", "Sábado · 9:00 a.m." } },
                    new() { Nombre = "Cardio Dance", Color = "purple",
                            Horarios = { "Lunes · 6:00 p.m.", "Sábado · 8:00 a.m." } },
                    new() { Nombre = "Cardio Step", Color = "purple",
                            Horarios = { "Miércoles · 6:00 p.m." } }
                },

                Entrenadores = new List<EntrenadorViewModel>
                {
                    new() { Nombre = "Francini Cubillo", Titulo = "Coach Fran · Personal Trainer", Color = "purple",
                            Foto = "/img/entrenadores/francini-cubillo.jpg", WhatsApp = "50660395779",
                            Especialidades = {
                                "Programas personalizados", "Online y presencial", "Evaluación con caliper",
                                "Adultos mayores", "Glúteos, hipertrofia y pérdida de grasa", "Levantamiento olímpico" } },

                    new() { Nombre = "Franciny Trejos", Titulo = "Promotora de la salud física · Ciencias del Movimiento Humano, UNA", Color = "cyan",
                            Foto = "/img/entrenadores/franciny-trejos.jpg",
                            Especialidades = {
                                "Personal trainer", "Fuerza y halterofilia", "Rehabilitación cardiaca fase III",
                                "Movilidad y estiramiento", "Programación en gym y casa", "Adulto mayor", "Rehabilitación de lesiones" } }
                },

                Galeria = new List<GaleriaItem>
                {
                    new() { Imagen = "/img/galeria/pesas.jpg",     Titulo = "Sala de pesas", Ancha = true },
                    new() { Imagen = "/img/galeria/cross.jpg",     Titulo = "Cross" },
                    new() { Imagen = "/img/galeria/dance.jpg",     Titulo = "Cardio Dance" },
                    new() { Imagen = "/img/galeria/funcional.jpg", Titulo = "Funcionales" },
                    new() { Imagen = "/img/galeria/hyrox.jpg",     Titulo = "Hyrox" }
                }
            };

            return View(model);
        }
    }
}