using System;

namespace MedControl.Classes
{
    public class Paciente : Pessoa
    {
        public static int TotalPacientes = 0;
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Paciente(
            string nome,
            string cpf,
            string telefone,
            string email,
            DateTime dataNascimento,
            string endereco)
            : base(nome, cpf, telefone, email)
        {
            this.DataNascimento = dataNascimento;
            this.Endereco = endereco;

            TotalPacientes++;
        }
        public override string TipoPessoa()
        {
            return "Paciente";
        }
    }
}