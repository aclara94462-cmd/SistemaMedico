using System;

namespace MedControl.Classes
{
    public class Atendimento
    {
        public Consulta Consulta { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtendimento { get; set; }

        public Atendimento(
            Consulta consulta,
            string descricao,
            DateTime dataAtendimento)
        {
            this.Consulta = consulta;
            this.Descricao = descricao;
            this.DataAtendimento = dataAtendimento;
        }
    }
}