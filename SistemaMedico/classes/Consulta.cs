using System;

namespace MedControl.Classes
{
    public class Consulta
    {
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Status { get; set; }

        public Consulta(
            Paciente paciente,
            Medico medico,
            DateTime data,
            string horario)
        {
            this.Paciente = paciente;
            this.Medico = medico;
            this.Data = data;
            this.Horario = horario;
            this.Status = "Agendada";
        }
    }
}