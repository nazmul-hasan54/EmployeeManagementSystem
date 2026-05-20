namespace EmployeeManagementSystem.Models
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public Employee Employee { get; set; }
    }
}
