using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDp
{
    public class LoanManager
    {
        //چه تعداد امانت داده شده
        public int IsLoan(int bookId)
        {
            return 2;
        }


        //لیست امانت های اون کتاب را برمی گرداند
        public List<Loan> GetLoans(int bookId)
        {
            return new List<Loan>()
            {
                new Loan()
                {
                    ExpiredDate = DateTime.Now.AddDays(-15),
                    User = new User()
                {
                    Id = 2,
                    Title = "User1",
                    CellPhoneNumber = "342342424"
                }
                },
                new Loan()
                {
                    ExpiredDate = DateTime.Now.AddDays(5),
                    User = new User()
                        {
                            Id = 56,
                            Title = "User56",
                            CellPhoneNumber = "324324324324"
                        }
                }
            };
        }
    }
}
