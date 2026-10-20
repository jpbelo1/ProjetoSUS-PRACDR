using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSUS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        
        private void ButtonCancel2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLogin.Text) || string.IsNullOrWhiteSpace(TextBoxSenha.Text))
            {
                MessageBox.Show("Por favor, preencha o ID e a Senha do funcionário.");
                return; 
            }

            SessaoSistema.FuncionarioID = TextBoxLogin.Text;

            MessageBox.Show("Login realizado com sucesso!");

            this.Close();
        }
    }
}
