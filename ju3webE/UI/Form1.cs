using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ju3webE.DTO;
using ju3webE.BLL;

namespace ju3webE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            //criar obj DTO
            LoginDTO loginDTO = new LoginDTO()
            {
                Email = Email.Text,
                Senha = Senha.Text,
            };

            //criar obj BLL
            LoginBLL loginBLL = new LoginBLL();

            //chamar BLL
            bool retorno = loginBLL.GetLoginBLL(loginDTO);

            if (retorno)
            {
                MessageBox.Show("Login OK");
            }
            else
            {
                MessageBox.Show("Falha no login");
            }

        }
    }
}
