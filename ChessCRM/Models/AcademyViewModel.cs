using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChessCRM.Models
{
    public class AcademyViewModel
    {
        public List<Product> CurrentProducts { get; set; }
        public List<Product> AllProducts { get; set; }

        public AcademyViewModel()
        {
            CurrentProducts = new List<Product>();
            AllProducts = new List<Product>();
        }
    }
}
