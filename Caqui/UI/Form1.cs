 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caqui.DTO;
using Caqui.BLL;

namespace Caqui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Criar objeto da DTO
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };

            //Criar objeto da BLL
            LoginBLL loginBLL = new LoginBLL();


            //Chamar a BLL
            bool retorno = loginBLL.GetLoginBLL(loginDTO);

            if (retorno)
            {
                MessageBox.Show("Login OK");
            }
            else{
                MessageBox.Show("Falha no login");
            }
        }
    }
}
