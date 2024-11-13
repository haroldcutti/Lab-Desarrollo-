namespace Semana11LAB.Models
{
    public class Invoice
    {
        public int IdInvoices { get; set; }

        // Llave foránea
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        public ICollection<Detail> Details { get; set; }
    }
}
