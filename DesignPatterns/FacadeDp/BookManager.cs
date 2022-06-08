using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDp
{
    public class BookManager
    {
        public Book GetBook(int id)
        {
            return new Book()
            {
                Id = id,
                Title = "a book",
                Quantity = 3,
                IsLoanable = true
            };
        }
    }
}
