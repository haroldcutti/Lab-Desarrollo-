namespace Semana11LAB.Models
{
    public class Customer
    {
        public int IdCustomers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public bool Activo { get; set; } = true;

        public ICollection<Invoice> Invoices { get; set; }
    }
}
