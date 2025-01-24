namespace WebAppEmployeeCrudMvc.Models
{
    public class Employee
    {

        public int IdEmployee { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public DateOnly ContractDate { get; set; }
        public bool Active { get; set; }
    }
}
