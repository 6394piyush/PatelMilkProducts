using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PatelMilkProducts.Interfaces
{
    public interface IKhaliOperations
    {
        List<Khali> GetAllKhalis();
        bool CreateKhali(Khali khali);
        Khali FindKhali(int? id);

        bool EditKhali(Khali khali);
        bool DeleteKhali(int? id);
        List<Khali> MonthlyEntries(int month);
        SelectList editListKhali(int id, string village);
    }
}
