using MedControl.Classes;
using MedControl.Interfaces;
using System;
using System.Collections.Generic;

namespace MedControl.Services
{
    public class ClinicaService : IRepositorio
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Medico> medicos = new List<Medico>();
        private List<Consulta> consultas = new List<Consulta>();
        private List<Especialidade> especialidades = new List<Especialidade>();
        public void CadastrarPaciente()
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE PACIENTE ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome não pode ficar vazio.");
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome não pode ficar vazio.");
            }

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new Exception("O CPF não pode ficar vazio.");
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new Exception("O CPF não pode ficar vazio.");
            }

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(telefone))
            {
                throw new Exception("O telefone não pode ficar vazio.");
            }

            Console.Write("Email: ");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("O email não pode ficar vazio.");
            }

            Console.Write("Data de nascimento (dd/MM/yyyy): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(endereco))
            {
                throw new Exception("O endereço não pode ficar vazio.");
            }

            Paciente paciente = new Paciente(
                nome,
                cpf,
                telefone,
                email,
                dataNascimento,
                endereco
            );

            pacientes.Add(paciente);

            Console.WriteLine("\nPaciente cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void CadastrarEspecialidade()
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE ESPECIALIDADE ===");

            Console.Write("Nome da especialidade: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome da especialidade não pode ficar vazio.");
            }

            Especialidade especialidade = new Especialidade(nome);

            especialidades.Add(especialidade);

            Console.WriteLine("\nEspecialidade cadastrada com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void CadastrarMedico()
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE MÉDICO ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome não pode ficar vazio.");
            }

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new Exception("O CPF não pode ficar vazio.");
            }

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(telefone))
            {
                throw new Exception("O telefone não pode ficar vazio.");
            }

            Console.Write("Email: ");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("O email não pode ficar vazio.");
            }

            Console.Write("CRM: ");
            string crm = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(crm))
            {
                throw new Exception("O CRM não pode ficar vazio.");
            }

            Console.Write("Especialidade: ");
            string nomeEspecialidade = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeEspecialidade))
            {
                throw new Exception("A especialidade não pode ficar vazia.");
            }

            Especialidade especialidade = new Especialidade(nomeEspecialidade);

            Medico medico = new Medico(
                nome,
                cpf,
                telefone,
                email,
                crm,
                especialidade
            );

            medicos.Add(medico);

            Console.WriteLine("\nMédico cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void ListarPacientes()
        {
            Console.Clear();
            Console.WriteLine("=== PACIENTES CADASTRADOS ===");

            if (pacientes.Count == 0)
            {
                Console.WriteLine("Nenhum paciente cadastrado.");
            }
            else
            {
                foreach (Paciente paciente in pacientes)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Nome: " + paciente.Nome);
                    Console.WriteLine("CPF: " + paciente.CPF);
                    Console.WriteLine("Telefone: " + paciente.Telefone);
                    Console.WriteLine("Email: " + paciente.Email);
                    Console.WriteLine("Data de nascimento: " + paciente.DataNascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Endereço: " + paciente.Endereco);
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void ListarMedicos()
        {
            Console.Clear();
            Console.WriteLine("=== MÉDICOS CADASTRADOS ===");

            if (medicos.Count == 0)
            {
                Console.WriteLine("Nenhum médico cadastrado.");
            }
            else
            {
                foreach (Medico medico in medicos)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Nome: " + medico.Nome);
                    Console.WriteLine("CPF: " + medico.CPF);
                    Console.WriteLine("Telefone: " + medico.Telefone);
                    Console.WriteLine("Email: " + medico.Email);
                    Console.WriteLine("CRM: " + medico.CRM);
                    Console.WriteLine("Especialidade: " + medico.Especialidade.Nome);
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void CadastrarConsulta()
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE CONSULTA ===");

            if (pacientes.Count == 0)
            {
                Console.WriteLine("Não existem pacientes cadastrados.");
                Console.ReadKey();
                return;
            }

            if (medicos.Count == 0)
            {
                Console.WriteLine("Não existem médicos cadastrados.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nPacientes:");
            for (int i = 0; i < pacientes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pacientes[i].Nome}");
            }

            Console.Write("Escolha o paciente: ");
            int pacienteEscolhido = int.Parse(Console.ReadLine());
            if (pacienteEscolhido < 1 || pacienteEscolhido > pacientes.Count)
            {
                throw new Exception("Paciente inválido.");
            }

            Console.WriteLine("\nMédicos:");
            for (int i = 0; i < medicos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Dr(a). {medicos[i].Nome} - {medicos[i].Especialidade.Nome}");
            }

            Console.Write("Escolha o médico: ");
            int medicoEscolhido = int.Parse(Console.ReadLine());
            if (medicoEscolhido < 1 || medicoEscolhido > medicos.Count)
            {
                throw new Exception("Médico inválido.");
            }

            Console.Write("Data da consulta (dd/MM/yyyy): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime data))
            {
                throw new Exception("Data inválida. Digite uma data no formato dd/MM/yyyy.");
            }

            Console.Write("Horário da consulta: ");
            string horario = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(horario))
            {
                throw new Exception("O horário não pode ficar vazio.");
            }

            for (int i = 0; i < consultas.Count; i++)
            {
                if (consultas[i].Medico == medicos[medicoEscolhido - 1] &&
                    consultas[i].Data.Date == data.Date &&
                    consultas[i].Horario == horario &&
                    consultas[i].Status == "Agendada")
                {
                    throw new Exception("Esse médico já possui uma consulta agendada nesse dia e horário.");
                }
            }

            Paciente paciente = pacientes[pacienteEscolhido - 1];
            Medico medico = medicos[medicoEscolhido - 1];

            Consulta consulta = new Consulta(
                paciente,
                medico,
                data,
                horario
            );

            consultas.Add(consulta);

            Console.WriteLine("\nConsulta cadastrada com sucesso!");
            Console.WriteLine("Status: " + consulta.Status);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void ListarConsultas()
        {
            Console.Clear();
            Console.WriteLine("=== CONSULTAS CADASTRADAS ===");

            if (consultas.Count == 0)
            {
                Console.WriteLine("Nenhuma consulta cadastrada.");
            }
            else
            {
                foreach (Consulta consulta in consultas)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Paciente: " + consulta.Paciente.Nome);
                    Console.WriteLine("Médico: " + consulta.Medico.Nome);
                    Console.WriteLine("Especialidade: " + consulta.Medico.Especialidade.Nome);
                    Console.WriteLine("Data: " + consulta.Data.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Horário: " + consulta.Horario);
                    Console.WriteLine("Status: " + consulta.Status);
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void CancelarConsulta()
        {
            Console.Clear();
            Console.WriteLine("=== CANCELAR CONSULTA ===");

            if (consultas.Count == 0)
            {
                Console.WriteLine("Nenhuma consulta cadastrada.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < consultas.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1} - {consultas[i].Paciente.Nome} | " +
                    $"{consultas[i].Data:dd/MM/yyyy} | " +
                    $"{consultas[i].Horario} | " +
                    $"Status: {consultas[i].Status}"
                );
            }

            Console.Write("\nEscolha a consulta que deseja cancelar: ");
            int escolha = int.Parse(Console.ReadLine());

            Consulta consulta = consultas[escolha - 1];

            if (consulta.Status == "Cancelada")
            {
                Console.WriteLine("Essa consulta já está cancelada.");
            }
            else if (consulta.Status == "Realizada")
            {
                Console.WriteLine("Não é possível cancelar uma consulta já realizada.");
            }
            else
            {
                consulta.Status = "Cancelada";
                Console.WriteLine("Consulta cancelada com sucesso!");
            }

            Console.ReadKey();
        }
        public void RegistrarAtendimento()
        {
            Console.Clear();
            Console.WriteLine("=== REGISTRAR ATENDIMENTO ===");

            if (consultas.Count == 0)
            {
                Console.WriteLine("Nenhuma consulta cadastrada.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < consultas.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1} - {consultas[i].Paciente.Nome} | " +
                    $"{consultas[i].Data:dd/MM/yyyy} | " +
                    $"{consultas[i].Horario} | " +
                    $"Status: {consultas[i].Status}"
                );
            }

            Console.Write("\nEscolha a consulta: ");
            int escolha = int.Parse(Console.ReadLine());

            Consulta consulta = consultas[escolha - 1];

            if (consulta.Status == "Cancelada")
            {
                Console.WriteLine("Não é possível registrar atendimento de uma consulta cancelada.");
                Console.ReadKey();
                return;
            }
            if (consulta.Status == "Realizada")
            {
                Console.WriteLine("Essa consulta já possui um atendimento registrado.");
                Console.ReadKey();
                return;
            }

            Console.Write("Descrição do atendimento: ");
            string descricao = Console.ReadLine();

            Atendimento atendimento = new Atendimento(
                consulta,
                descricao,
                DateTime.Now
            );

            consulta.Status = "Realizada";

            Console.WriteLine("\nAtendimento registrado com sucesso!");
            Console.WriteLine("Status da consulta: " + consulta.Status);
            Console.WriteLine("Data do atendimento: " + atendimento.DataAtendimento.ToString("dd/MM/yyyy HH:mm"));

            Console.ReadKey();
        }
        public void Salvar()
        {
            Console.WriteLine("Dados salvos com sucesso!");
        }

        public void Listar()
        {
            Console.WriteLine("Pacientes cadastrados: " + pacientes.Count);
            Console.WriteLine("Médicos cadastrados: " + medicos.Count);
            Console.WriteLine("Consultas cadastradas: " + consultas.Count);
        }
    }
}