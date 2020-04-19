using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatelMilkProducts.Interfaces
{
    interface IMilkEntryOperations
    {
        IList<MilkEntryUpload> GetMilkEntry();
        MilkEntryUpload FindMilkEntry(int id);

        bool EditMilkEntry(MilkEntryUpload milkEntry);
        bool DeleteMilkEntry(int id);
    }
}
