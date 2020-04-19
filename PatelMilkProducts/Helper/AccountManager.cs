using PatelMilkProducts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Helper
{
    public class AccountManager
    {
        private IAccountsOperations _accountsOperations;

        public AccountManager(IAccountsOperations operations)
        {
            _accountsOperations = operations;
        }

        public IAccountsOperations GetAccountsOperations()
        {
            return _accountsOperations;
        }
    }
}