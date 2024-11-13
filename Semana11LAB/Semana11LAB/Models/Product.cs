namespace Semana11LAB.Models
{
    public class Product
    {
        public int IdProducts { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool Activo { get; set; } = true; // Activo por defecto

        public ICollection<Detail> Details { get; set; }
    }
}
