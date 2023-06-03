using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caqui.DAL;
using Caqui.DTO;

namespace Caqui.BLL
{
    internal class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            LoginDAL loginDAL = new LoginDAL();

            return loginDAL.GetLoginDAL(loginDTO);
        }
    }
}
