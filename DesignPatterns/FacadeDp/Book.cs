using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDp
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public bool IsLoanable { get; set; }
    }
}
