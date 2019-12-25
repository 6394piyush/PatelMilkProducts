using PatelMilkProducts.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class ImportExcel
    {
        [Required(ErrorMessage ="Please select a File")]
        [FileExt(Allow = ".xls,.xlsx", ErrorMessage = "Only excel file")]
        public HttpPostedFileBase file { get; set; }
    }
}