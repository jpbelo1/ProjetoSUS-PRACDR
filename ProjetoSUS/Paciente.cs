using System;
using System.Collections.Generic;

namespace ProjetoSUS
{
    // ==========================================
    // 1. AS CLASSES DAS TABELAS SECUNDÁRIAS
    // ==========================================
    public class Consulta
    {
        public string tipoCons { get; set; }
        public string dataCons { get; set; }
    }

    public class Exame
    {
        public string tipoExame { get; set; }
        public string localExame { get; set; }
        public string dataExame { get; set; }
    }

    public class Med
    {
        public string medIns { get; set; }
        public string localRet { get; set; }
        public string dataRet { get; set; }
    }

    // ==========================================
    // 2. A CLASSE PRINCIPAL DO PACIENTE
    // ==========================================
    public class Paciente
    {
        // Aqui estão as suas "variáveis" de dados
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sus { get; set; }
        public string End { get; set; }
        public string Num { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string DataNascimento { get; set; }
        
        // Variáveis para as caixas de seleção (ComboBox)
        public string Raca { get; set; }
        public string Gen { get; set; }

        // Variáveis para os contatos do paciente
        public string TelPac { get; set; }
        public string EmailPac { get; set; }
        public string NomeAcomp { get; set; }
        public string TelAcomp { get; set; }
        public string EmailAcomp { get; set; }

        // Variável para textos de leitura médica
        public string TipoDoen { get; set; }
        public string Cid { get; set; }
        public string UnidAtend { get; set; }
        public string Obs { get; set; }

        // Variáveis especiais (Listas) que vão guardar todas as linhas das outras tabelas
        public List<Consulta> HistoricoConsultas { get; set; } = new List<Consulta>();
        public List<Exame> HistoricoExames { get; set; } = new List<Exame>();
        public List<Med> HistoricoMed { get; set; } = new List<Med>();
    }
}