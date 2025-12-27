using Application.Services.LoginUser;
using Application.Services.RegisterUser;

namespace Application.FacadePattern
{
    public interface IFacadeService
    {
        ILoginService loginService { get; }
        IRegisterService registerService { get; }
    }
    public class FacadeService : IFacadeService
    {
        private ILoginService? _loginService;
        private IRegisterService? _registerService;
        public ILoginService loginService
        {
            get
            {
                return _loginService = _loginService ?? new LoginService();
            }
        }

        public IRegisterService registerService
        {
            get
            {
                return _registerService = _registerService ?? new RegisterService();
            }
        }
    }

}
