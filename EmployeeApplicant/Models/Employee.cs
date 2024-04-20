namespace EmployeeApplicant.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public int PhoneNumber { get; set; }    

        public string Email { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

        public DateTime StartDate { get; set; }

        public int is_first { get; set; }

        public string job_role { get; set; }




    
    }
}
