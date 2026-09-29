namespace MedControl.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string cpf, string telefone, string email)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;
        }
        public virtual string TipoPessoa()
        {
            return "Pessoa";
        }
    }
}