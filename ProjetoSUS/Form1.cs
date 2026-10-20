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
    public partial class Form1 : Form
    {

        List<Paciente> bancoDeDadosPacientes = new List<Paciente>();

        public Form1()
        {
            InitializeComponent();

            CarregarPacientesIniciais();

            AtualizarBotoesDeLogin();
        }

        private void AtualizarContador()
        {
            int quantidade = dgvPrinc.Rows.Count;

            labelTotalPac.Text = $"Total de Pacientes Cadastrados: {quantidade}";
        }

        private void CarregarPacientesIniciais()
        {
            // Paciente 1
            Paciente paciente1 = new Paciente();
            paciente1.Nome = "Maria da Silva";
            paciente1.Cpf = "123.456.789-00";
            paciente1.Sus = "1234678910";
            paciente1.End = "Rua das Flores";
            paciente1.Num = "35";
            paciente1.Bairro = "Conceição";
            paciente1.Cep = "12345-678";
            paciente1.DataNascimento = "15/05/1985";
            paciente1.Gen = "Homem Cis";
            paciente1.Raca = "Preto";

            // Contatos
            paciente1.TelPac = "(11) 98765-4321";
            paciente1.EmailPac = "maria@gmail.com";
            paciente1.NomeAcomp = "João da Silva";
            paciente1.TelAcomp = "(11) 91234-5678";
            paciente1.EmailAcomp = "joao@gmail.com";

            // Informações médicas
            paciente1.TipoDoen = "Atrofia Muscular Espinhal (AME)";
            paciente1.Cid = "CID-10 G12.0";
            paciente1.UnidAtend = "UBS Conceição";
            paciente1.Obs = "Paciente necessita de uso de cadeira de rodas para locomoção";

            // Adicionando informações nas tabelas
            Consulta consultaExemplo = new Consulta();
            consultaExemplo.tipoCons = "Rotina";
            consultaExemplo.dataCons = "10/01/2026";
            paciente1.HistoricoConsultas.Add(consultaExemplo);


            Exame exameExemplo = new Exame();
            exameExemplo.tipoExame = "Rotina";
            exameExemplo.localExame = "UBS Vila Mariana";
            exameExemplo.dataExame = "05/01/2026";
            paciente1.HistoricoExames.Add(exameExemplo);

            Med medExemplo = new Med();
            medExemplo.medIns = "Rotina";
            medExemplo.localRet = "UBS Vila Mariana";
            medExemplo.dataRet = "05/01/2026";
            paciente1.HistoricoMed.Add(medExemplo);

            bancoDeDadosPacientes.Add(paciente1);


            // Paciente 2
            Paciente paciente2 = new Paciente();
            paciente2.Nome = "Joaquim de Souza Santos";
            paciente2.Cpf = "987.654.321-00";
            paciente2.Sus = "10987654321";
            paciente2.End = "Rua das Moradas";
            paciente2.Num = "68";
            paciente2.Bairro = "Itaquera";
            paciente2.Cep = "98765-432";
            paciente2.DataNascimento = "13/06/2012";
            paciente2.Gen = "Homem Cis";
            paciente2.Raca = "Branco";

            // Contatos
            paciente2.TelPac = "(11) 98765-4321";
            paciente2.EmailPac = "joaquim@gmail.com";
            paciente2.NomeAcomp = "Vania de Souza Silva";
            paciente2.TelAcomp = "(11) 91234-5678";
            paciente2.EmailAcomp = "vania@gmail.com";

            // Informações médicas
            paciente2.TipoDoen = "Fibrose Cística";
            paciente2.Cid = "CID-10 E84";
            paciente2.UnidAtend = "UBS Tatuapé";
            paciente2.Obs = "Paciente necessita de auxilio de aparelhos para respirar";

            // Adicionando informações nas tabelas
            Consulta consultaExemplo2 = new Consulta();
            consultaExemplo2.tipoCons = "Rotina";
            consultaExemplo2.dataCons = "13/11/2026";
            paciente2.HistoricoConsultas.Add(consultaExemplo);


            Exame exameExemplo2 = new Exame();
            exameExemplo2.tipoExame = "Rotina";
            exameExemplo2.localExame = "UBS Carrão";
            exameExemplo2.dataExame = "07/07/2026";
            paciente2.HistoricoExames.Add(exameExemplo);

            Med medExemplo2 = new Med();
            medExemplo2.medIns = "Rotina";
            medExemplo2.localRet = "UBS Carrão";
            medExemplo2.dataRet = "08/09/2026";
            paciente2.HistoricoMed.Add(medExemplo);

            bancoDeDadosPacientes.Add(paciente2);


            // Paciente 3
            Paciente paciente3 = new Paciente();
            paciente3.Nome = "Andreia Pereira";
            paciente3.Cpf = "283.754.453-00";
            paciente3.Sus = "9452960367";
            paciente3.End = "Rua dos Andaimes";
            paciente3.Num = "1523";
            paciente3.Bairro = "Tucuruvi";
            paciente3.Cep = "85632-832";
            paciente3.DataNascimento = "29/02/1998";
            paciente3.Gen = "Mulher Transsexual";
            paciente3.Raca = "Indígena";

            // Contatos
            paciente3.TelPac = "(11) 98765-4321";
            paciente3.EmailPac = "Andreia@gmail.com";
            paciente3.NomeAcomp = "Lucas Pereira";
            paciente3.TelAcomp = "(11) 91234-5678";
            paciente3.EmailAcomp = "lucas@gmail.com";

            // Informações médicas
            paciente3.TipoDoen = "Hemofilia A";
            paciente3.Cid = "CID-10 D66";
            paciente3.UnidAtend = "UBS Santana";
            paciente3.Obs = "Nada a declarar";

            // Adicionando informações nas tabelas
            Consulta consultaExemplo3 = new Consulta();
            consultaExemplo3.tipoCons = "Rotina";
            consultaExemplo3.dataCons = "04/05/2026";
            paciente3.HistoricoConsultas.Add(consultaExemplo);


            Exame exameExemplo3 = new Exame();
            exameExemplo3.tipoExame = "Rotina";
            exameExemplo3.localExame = "UBS Santana";
            exameExemplo3.dataExame = "07/07/2026";
            paciente3.HistoricoExames.Add(exameExemplo);

            Med medExemplo3 = new Med();
            medExemplo3.medIns = "Gases";
            medExemplo3.localRet = "UBS Santana";
            medExemplo3.dataRet = "08/11/2026";
            paciente3.HistoricoMed.Add(medExemplo);

            bancoDeDadosPacientes.Add(paciente3);


            // Paciente 4
            Paciente paciente4 = new Paciente();
            paciente4.Nome = "Valéria Ronaldo";
            paciente4.Cpf = "368.375.095-90";
            paciente4.Sus = "0285648392";
            paciente4.End = "Av. Paulista";
            paciente4.Num = "2428";
            paciente4.Bairro = "Bela Vista";
            paciente4.Cep = "94621-643";
            paciente4.DataNascimento = "21/04/1978";
            paciente4.Gen = "Mulher Cis";
            paciente4.Raca = "Branco";

            // Contatos
            paciente4.TelPac = "(11) 98765-4321";
            paciente4.EmailPac = "valeria@gmail.com";
            paciente4.NomeAcomp = "Wanderlei Nascimento";
            paciente4.TelAcomp = "(11) 91234-5678";
            paciente4.EmailAcomp = "wanderlei@gmail.com";

            // Informações médicas
            paciente4.TipoDoen = "Osteogênese Imperfeita";
            paciente4.Cid = "CID-10 Q78.0";
            paciente4.UnidAtend = "UBS Bela Vista";
            paciente4.Obs = "Paciente acamada";

            // Adicionando informações nas tabelas
            Consulta consultaExemplo4 = new Consulta();
            consultaExemplo4.tipoCons = "Rotina";
            consultaExemplo4.dataCons = "13/11/2026";
            paciente4.HistoricoConsultas.Add(consultaExemplo);

            Exame exameExemplo4 = new Exame();
            exameExemplo4.tipoExame = "densitometria óssea";
            exameExemplo4.localExame = "UBS Pinheiros";
            exameExemplo4.dataExame = "07/12/2026";
            paciente4.HistoricoExames.Add(exameExemplo);

            Med medExemplo4 = new Med();
            medExemplo4.medIns = "Bisfosfonatos";
            medExemplo4.localRet = "UBS Pinheiros";
            medExemplo4.dataRet = "07/12/2026";
            paciente4.HistoricoMed.Add(medExemplo);

            bancoDeDadosPacientes.Add(paciente4);


            // Paciente 5
            Paciente paciente5 = new Paciente();
            paciente5.Nome = "Gustavo Hiroto";
            paciente5.Cpf = "987.654.321-00";
            paciente5.Sus = "0129387464";
            paciente5.End = "Rua Chico de Paulo";
            paciente5.Num = "126";
            paciente5.Bairro = "Freguesia do Ó";
            paciente5.Cep = "98765-432";
            paciente5.DataNascimento = "20/04/2006";
            paciente5.Gen = "Homem Cis";
            paciente5.Raca = "Amarelo";

            // Contatos
            paciente5.TelPac = "(11) 98765-4321";
            paciente5.EmailPac = "hiroto@gmail.com";
            paciente5.NomeAcomp = "Nezuko Hiroto";
            paciente5.TelAcomp = "(11) 91234-5678";
            paciente5.EmailAcomp = "nezuhiro@gmail.com";

            // Informações médicas
            paciente5.TipoDoen = "Síndrome de Prader-Willi";
            paciente5.Cid = "CID-10 Q87.1";
            paciente5.UnidAtend = "UBS Brasilândia";
            paciente5.Obs = "Paciente necessita de acompanhamento constante de Psiquiatra e Nutricionista";

            // Adicionando informações nas tabelas
            Consulta consultaExemplo5 = new Consulta();
            consultaExemplo5.tipoCons = "Rotina";
            consultaExemplo5.dataCons = "13/11/2026";
            paciente5.HistoricoConsultas.Add(consultaExemplo);


            Exame exameExemplo5 = new Exame();
            exameExemplo5.tipoExame = "Rotina";
            exameExemplo5.localExame = "UBS Freguesia do Ó";
            exameExemplo5.dataExame = "25/09/2026";
            paciente5.HistoricoExames.Add(exameExemplo);

            Med medExemplo5 = new Med();
            medExemplo5.medIns = "Rotina";
            medExemplo5.localRet = "UBS Freguesia do Ó";
            medExemplo5.dataRet = "18/03/2026";
            paciente5.HistoricoMed.Add(medExemplo);

            bancoDeDadosPacientes.Add(paciente5);


            foreach (Paciente p in bancoDeDadosPacientes)
            {
                dgvPrinc.Rows.Add(
                    p.Nome,
                    p.Cpf,
                    p.DataNascimento,
                    p.TipoDoen,
                    p.Cid,
                    p.UnidAtend,
                    p.TelPac,
                    p.EmailPac,
                    p.NomeAcomp,
                    p.TelAcomp,
                    p.EmailAcomp
                );
            }
        }

        private void CadPac_Click(object sender, EventArgs e)
        {
            if (SessaoSistema.EstaLogado == false)
            {
                MessageBox.Show(
                    "Acesso Negado! Por favor, faça o login no sistema primeiro para poder cadastrar um novo paciente.",
                    "Login Necessário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Form2 telaCadastro = new Form2();

            telaCadastro.ShowDialog();

            if (telaCadastro.ShowDialog() == DialogResult.OK)
            {
                bancoDeDadosPacientes.Add(telaCadastro.PacienteCriado);

                dgvPrinc.Rows.Add(
                    telaCadastro.PacienteCriado.Nome,
                    telaCadastro.PacienteCriado.Cpf,
                    telaCadastro.PacienteCriado.DataNascimento,
                    telaCadastro.PacienteCriado.TipoDoen,
                    telaCadastro.PacienteCriado.Cid,
                    telaCadastro.PacienteCriado.UnidAtend,
                    telaCadastro.PacienteCriado.TelPac,
                    telaCadastro.PacienteCriado.EmailPac,
                    telaCadastro.PacienteCriado.NomeAcomp,
                    telaCadastro.PacienteCriado.TelAcomp,
                    telaCadastro.PacienteCriado.EmailAcomp
                );
            }
            AtualizarContador();
        }


        private void TextPesq_TextChanged(object sender, EventArgs e)
        {
            dgvPrinc.Rows.Clear();

            string termoBuscado = TextPesq.Text.ToLower();

            foreach (Paciente p in bancoDeDadosPacientes)
            {
                if (p.Nome.ToLower().Contains(termoBuscado) || p.Cpf.Contains(termoBuscado) || p.DataNascimento.Contains(termoBuscado) || p.TipoDoen.ToLower().Contains(termoBuscado) || p.Cid.ToLower().Contains(termoBuscado) || p.UnidAtend.ToLower().Contains(termoBuscado) || p.NomeAcomp.ToLower().Contains(termoBuscado))
                {
                    dgvPrinc.Rows.Add(
                        p.Nome,
                        p.Cpf,
                        p.DataNascimento,
                        p.TipoDoen,
                        p.Cid,
                        p.UnidAtend,
                        p.TelPac,
                        p.EmailPac,
                        p.NomeAcomp,
                        p.TelAcomp,
                        p.EmailAcomp
                    );
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarContador();
        }

        private void AtualizarBotoesDeLogin()
        {
            if (SessaoSistema.EstaLogado == true)
            {
                ButtonLogin.Enabled = false; 
                buttonLogout.Enabled = true;      
            }
            else
            {
                ButtonLogin.Enabled = true; 
                buttonLogout.Enabled = false;     
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Form4 telaLogin= new Form4();

            telaLogin.ShowDialog();

            AtualizarBotoesDeLogin();
        }

        private void dgvPrinc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nomeClicado = dgvPrinc.Rows[e.RowIndex].Cells[0].Value?.ToString();

                Paciente pacienteEncontrado = bancoDeDadosPacientes.FirstOrDefault(p => p.Nome == nomeClicado);

                if (pacienteEncontrado != null)
                {
                    Form5 telaRelatorio = new Form5();

                    telaRelatorio.PreencherRelatorio(pacienteEncontrado);

                    telaRelatorio.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro: Os dados completos deste paciente não foram encontrados no sistema.");
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (SessaoSistema.EstaLogado == false)
            {
                MessageBox.Show("Não há nenhum usuário logado no momento.");
                return;
            }

            SessaoSistema.FuncionarioID = "";

            MessageBox.Show(
                "Conta desconectada com sucesso. O acesso aos cadastros foi bloqueado.",
                "Logout",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            AtualizarBotoesDeLogin();
        }
    }
}
