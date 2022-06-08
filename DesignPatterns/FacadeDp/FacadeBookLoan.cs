using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDp
{
    public class FacadeBookLoan
    {
        private BookManager _bookManager;
        private LoanManager _loanManager;

        public FacadeBookLoan()
        {
             _bookManager = new BookManager();
             _loanManager = new LoanManager();
        }

        public int IsLoanable(int bookid)
        {
            var book = _bookManager.GetBook(2);
            if (book == null)
            {
                return -2;
            }
            if(!book.IsLoanable)
                return -1;

            var howManyBookIsLoaned = _loanManager.IsLoan(2);

            return book.Quantity - howManyBookIsLoaned;
        }
    }
}
