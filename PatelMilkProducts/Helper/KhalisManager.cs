using PatelMilkProducts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Helper
{
    public class KhalisManager
    {
        private IKhaliOperations _khaliOperations;
        public KhalisManager(IKhaliOperations operations)
        {
            _khaliOperations = operations;
        }
        public IKhaliOperations GetKhaliOperations()
        {
            return _khaliOperations;
        }

    }
}