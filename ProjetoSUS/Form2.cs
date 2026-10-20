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
    public partial class Form2 : Form
    {
        public Paciente PacienteCriado { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }
        

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(TextConsulta.Text) || string.IsNullOrWhiteSpace(TextData.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar.");
                return;
            }

            DgvConsultas.Rows.Add(TextConsulta.Text, TextData.Text);

            TextConsulta.Clear();
            TextData.Clear();

            TextConsulta.Focus();
        }

        private void ButtonAddExames_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextExame.Text) || string.IsNullOrWhiteSpace(TextLocal.Text) || string.IsNullOrWhiteSpace(TextDataE.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar.");
                return;
            }

            DgvExames.Rows.Add(TextExame.Text, TextLocal.Text, TextDataE.Text);

            TextExame.Clear();
            TextLocal.Clear();
            TextDataE.Clear();

            TextExame.Focus();
        }

        private void ButtonAddMed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextMed.Text) || string.IsNullOrWhiteSpace(TextLocalM.Text) || string.IsNullOrWhiteSpace(TextDataM.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de adicionar.");
                return;
            }

            DgvMed.Rows.Add(TextMed.Text, TextLocalM.Text, TextDataM.Text);

            TextMed.Clear();
            TextLocalM.Clear();
            TextDataM.Clear();

            TextMed.Focus();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            PacienteCriado = new Paciente();


            PacienteCriado.Nome = textNome.Text;
            PacienteCriado.Cpf = textCpfPac.Text;
            PacienteCriado.Sus = textSus.Text;
            PacienteCriado.End = textEnd.Text;
            PacienteCriado.Num = textNum.Text;
            PacienteCriado.Bairro = textBairro.Text;
            PacienteCriado.Cep = textCep.Text;
            PacienteCriado.DataNascimento = dtpNasc.Value.ToString("dd/MM/yyyy");
            PacienteCriado.Gen = comboBoxGen.Text;
            PacienteCriado.Raca = comboBoxRaca.Text;
            PacienteCriado.TelPac = textTelPac.Text;
            PacienteCriado.EmailPac = textEmailPac.Text;
            PacienteCriado.NomeAcomp = textNomeAcomp.Text;
            PacienteCriado.TelAcomp = textTelAcomp.Text;
            PacienteCriado.EmailAcomp = textEmailAcomp.Text;
            PacienteCriado.TipoDoen = textTipoDoen.Text;
            PacienteCriado.Cid = textCid.Text;
            PacienteCriado.UnidAtend = textUnidAtend.Text;
            PacienteCriado.Obs = textDescMed.Text;

            foreach (DataGridViewRow linha in DgvConsultas.Rows)
            {
                if (linha.IsNewRow == false)
                {
                    Consulta novaConsulta = new Consulta();
                    novaConsulta.tipoCons = linha.Cells[0].Value?.ToString();
                    novaConsulta.dataCons = linha.Cells[1].Value?.ToString();
                    
                    PacienteCriado.HistoricoConsultas.Add(novaConsulta);
                }
            }

            foreach (DataGridViewRow linha in DgvExames.Rows)
            {
                if (linha.IsNewRow == false)
                {
                    Exame novoExame = new Exame();
                    novoExame.tipoExame = linha.Cells[0].Value?.ToString();
                    novoExame.localExame = linha.Cells[0].Value?.ToString();
                    novoExame.dataExame = linha.Cells[1].Value?.ToString();

                    PacienteCriado.HistoricoExames.Add(novoExame);
                }
            }

            foreach (DataGridViewRow linha in DgvMed.Rows)
            {
                if (linha.IsNewRow == false)
                {
                    Med novoMed = new Med();
                    novoMed.medIns = linha.Cells[0].Value?.ToString();
                    novoMed.localRet = linha.Cells[0].Value?.ToString();
                    novoMed.dataRet = linha.Cells[1].Value?.ToString();

                    PacienteCriado.HistoricoMed.Add(novoMed);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
