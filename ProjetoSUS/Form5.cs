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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void PreencherRelatorio(Paciente pacienteSelecionado)
        {
            
            textNome.Text = pacienteSelecionado.Nome;
            textCpfPac.Text = pacienteSelecionado.Cpf;
            textSus.Text = pacienteSelecionado.Sus;
            textEnd.Text = pacienteSelecionado.End;
            textNum.Text = pacienteSelecionado.Num;
            textBairro.Text = pacienteSelecionado.Bairro;
            textCep.Text = pacienteSelecionado.Cep;
            textDataNascimento.Text = pacienteSelecionado.DataNascimento;
            textGen.Text = pacienteSelecionado.Gen;
            textRaca.Text = pacienteSelecionado.Raca;
            textTelPac.Text = pacienteSelecionado.TelPac;
            textEmailPac.Text = pacienteSelecionado.EmailPac;
            textNomeAcomp.Text = pacienteSelecionado.NomeAcomp;
            textTelAcomp.Text = pacienteSelecionado.TelAcomp;
            textEmailAcomp.Text = pacienteSelecionado.EmailAcomp;
            textUnidAtend.Text = pacienteSelecionado.UnidAtend;
            textTipoDoen.Text = pacienteSelecionado.TipoDoen;
            textCid.Text = pacienteSelecionado.Cid;
            textDescMed.Text = pacienteSelecionado.Obs;

            DgvConsultas.Rows.Clear();
            DgvExames.Rows.Clear();
            DgvMed.Rows.Clear();

            foreach (Consulta c in pacienteSelecionado.HistoricoConsultas)
            {
                // Coloque as variáveis na exata ordem das colunas visíveis
                DgvConsultas.Rows.Add(c.tipoCons, c.dataCons);
            }

            foreach (Exame ex in pacienteSelecionado.HistoricoExames)
            {
                DgvExames.Rows.Add(ex.tipoExame, ex.localExame, ex.dataExame);
            }

            foreach (Med r in pacienteSelecionado.HistoricoMed)
            {
                // Lembre-se de verificar os nomes exatos que você colocou na sua classe Remedio
                DgvMed.Rows.Add(r.medIns, r.localRet, r.dataRet);
            }

        }
    }
}
