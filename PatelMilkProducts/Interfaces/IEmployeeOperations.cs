using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Interfaces
{
    public interface IEmployeeOperations
    {
        IList<Employees> GetEmployees();
        Employees FindEmployees(int id);

        bool EditEmployees(Employees emp);
        bool DeleteEmployees(int id);

    }
}