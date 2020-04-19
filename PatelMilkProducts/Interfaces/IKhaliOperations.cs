using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatelMilkProducts.Interfaces
{
    interface IKhaliOperations
    {
        IList<Khali> GetKhali();
        Khali FindKhali(int id);

        bool EditKhali(Khali khali);
        bool DeleteKhali(int id);
    }
}
