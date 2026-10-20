public static class SessaoSistema
{
    // Variável que vai guardar o ID do funcionário logado
    public static string FuncionarioID { get; set; } = "";

    // Uma verificação rápida para saber se tem alguém logado (Retorna verdadeiro ou falso)
    public static bool EstaLogado
    {
        get { return !string.IsNullOrEmpty(FuncionarioID); }
    }
}