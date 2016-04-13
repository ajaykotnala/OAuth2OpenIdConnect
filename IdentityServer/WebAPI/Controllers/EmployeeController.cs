using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController
    {
        [Route("List")]
        public Employee Get()
        {
            Employee employee = new Employee() {Name = "Ajay", Address = "Whitefields-Hyderabad, India." };
            return employee;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}