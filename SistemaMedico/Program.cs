using MedControl.Classes;
using MedControl.Services;
using System;

namespace MedControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClinicaService clinica = new ClinicaService();

            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine("       MEDCONTROL");
                Console.WriteLine(" Sistema de Gestão de Clínica");
                Console.WriteLine("=================================");
                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Cadastrar médico");
                Console.WriteLine("3 - Cadastrar especialidade");
                Console.WriteLine("4 - Cadastrar consulta");
                Console.WriteLine("5 - Listar pacientes");
                Console.WriteLine("6 - Listar médicos");
                Console.WriteLine("7 - Listar consultas");
                Console.WriteLine("8 - Cancelar consulta");
                Console.WriteLine("9 - Registrar atendimento");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("=================================");
                Console.Write("Escolha uma opção: ");

                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        try
                        {
                            clinica.CadastrarPaciente();
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("\nErro: " + erro.Message);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        try
                        {
                            clinica.CadastrarMedico();
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("\nErro: " + erro.Message);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        try
                        {
                            clinica.CadastrarEspecialidade();
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("\nErro: " + erro.Message);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        try
                        {
                            clinica.CadastrarConsulta();
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("\nErro: " + erro.Message);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 5:
                        clinica.ListarPacientes();
                        break;

                    case 6:
                        clinica.ListarMedicos();
                        break;

                    case 7:
                        clinica.ListarConsultas();
                        break;

                    case 8:
                        try
                        {
                            clinica.CancelarConsulta();
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("\nErro: " + erro.Message);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 9:
                        try
                        {
                            clinica.RegistrarAtendimento();
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("\nErro: " + erro.Message);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }
    }
}