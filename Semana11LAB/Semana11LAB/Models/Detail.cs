namespace Semana11LAB.Models
{
    public class Detail
    {
        public int IdDetails { get; set; }

        // Llave foránea para Product
        public int ProductID { get; set; }
        public Product Product { get; set; }

        // Llave foránea para Invoice
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }

        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }
    }
}
