using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ju3webE.DAL;
using ju3webE.DTO;

namespace ju3webE.BLL
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