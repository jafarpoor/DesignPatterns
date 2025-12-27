using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.RegisterUser
{
    public interface IRegisterService
    {
        void RegisterUser();
    }
    public class RegisterService : IRegisterService
    {
        public void RegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}
