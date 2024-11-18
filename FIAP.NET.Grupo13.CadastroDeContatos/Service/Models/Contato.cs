namespace FIAP.NET.Grupo13.CadastroDeContatos.Service.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int IdDDD { get; set; }
        public CodigoDDD CodigoDDD { get; set; }
    }
}
