namespace MedControl.Classes
{
    public class Medico : Pessoa
    {
        public string CRM { get; set; }
        public Especialidade Especialidade { get; set; }

        public Medico(
            string nome,
            string cpf,
            string telefone,
            string email,
            string crm,
            Especialidade especialidade)
            : base(nome, cpf, telefone, email)
        {
            this.CRM = crm;
            this.Especialidade = especialidade;
        }
        public override string TipoPessoa()
        {
            return "Médico";
        }
    }
}