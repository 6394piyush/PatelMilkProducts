using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PatelMilkProducts.Interfaces
{
    public interface IAccountsOperations
    {
        List<EmpAccount> GetAllAccounts();
        bool CreateEmpAccount(EmpAccount empAccount);
        EmpAccount FindEmpAccount(int? id);

        bool EditEmpAccount(EmpAccount emp);
        bool DeleteEmpAccount(int? id);
        List<EmpAccount> MonthlyEntries(int month);
        SelectList editListEmpAccounts(int id, string village);
    }
}
