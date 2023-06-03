using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ju3webE.DTO;

namespace ju3webE.DAL
{
    internal class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            if (loginDTO.Email == "admin@admin.com" && loginDTO.Senha == "1234")
            {
                return true;
            }
            return false;
        }
    }
}
