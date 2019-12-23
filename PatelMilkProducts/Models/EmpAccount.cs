using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class EmpAccount
    {
        public int Id { get; set; }
        public int EmployeesId { get; set; }
        public int Amount { get; set; }
        public string TransactionType { get; set; }
        public string Signature { get; set; }
        public string Comments { get; set; }

        public virtual Employees Employees { get; set; }
    }

    public enum TransactionType
    {
        Credit,
        Debit
    }

}