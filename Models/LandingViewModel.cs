namespace RhynoPerformance.Models
{
    public class LandingViewModel
    {
        public List<PlanViewModel> Planes { get; set; } = new();
        public List<ClaseViewModel> Clases { get; set; } = new();
        public List<EntrenadorViewModel> Entrenadores { get; set; } = new();
        public List<GaleriaItem> Galeria { get; set; } = new();
    }

    public class PlanViewModel
    {
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public string Periodo { get; set; } = "";
        public string ColorBadge { get; set; } = "";
        public bool Destacado { get; set; }
        public string? Nota { get; set; }
        public List<string> Beneficios { get; set; } = new();
    }

    public class ClaseViewModel
    {
        public string Nombre { get; set; } = "";
        public string Color { get; set; } = "";
        public bool SoloPremium { get; set; }
        public List<string> Horarios { get; set; } = new();
    }

    public class EntrenadorViewModel
    {
        public string Nombre { get; set; } = "";
        public string Titulo { get; set; } = "";
        public string Foto { get; set; } = "";
        public string Color { get; set; } = "";
        public string? WhatsApp { get; set; }
        public List<string> Especialidades { get; set; } = new();

        public string Iniciales =>
            string.Concat(Nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2).Select(p => p[0]));
    }

    public class GaleriaItem
    {
        public string Imagen { get; set; } = "";
        public string Titulo { get; set; } = "";
        public bool Ancha { get; set; }
    }
}