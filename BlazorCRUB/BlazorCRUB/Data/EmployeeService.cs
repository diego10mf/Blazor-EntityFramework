using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUB.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _Db;

        public EmployeeService(ApplicationDbContext db)
        {
            _Db = db;
        }

        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _Db.Employees.ToList();
            return empList;
        }

        public string Create(EmployeeInfo objemployee)
        {
            _Db.Employees.Add(objemployee);
            _Db.SaveChanges();
            return "Save Successfully";
        }

        public EmployeeInfo GetEmployeeById(int id)
        {
           EmployeeInfo employee = _Db.Employees.FirstOrDefault( s => s.EmployeeId == id);
            return employee;
        }

        public string UpdateEmployee(EmployeeInfo objemployee)
        {
            _Db.Employees.Update(objemployee);
            _Db.SaveChanges();
            return "Update Successfully";
        }

        public string DeleteEmployee(EmployeeInfo objemployee)
        {
            _Db.Remove(objemployee);
            _Db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
