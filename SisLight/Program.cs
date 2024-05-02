using SisLight.Lampadas;
using System.Security.Cryptography.X509Certificates;

namespace SisLight.Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuLampadas();
        }

        public static void MenuLampadas()
        {
            bool loop = true;

            while (loop == true)
            {
                Console.WriteLine("Selecione a opção desejada: \n1 – Cadastrar lâmpadas\r\n2 – Ligar lâmpada\r\n3 – Desligar lâmpada\r\n4 – Consultar potência utilizada\r\n5 – Sair");
                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Lampada.CadastrarLampada();
                        break;
                    case 2:
                        Console.WriteLine("Insira o código da lâmpada que deseja ligar:");
                        int codigo1 = Convert.ToInt32(Console.ReadLine());
                        Lampada.LigarLampada(codigo1);
                        break;
                    case 3:
                        Console.WriteLine("Insira o código da lâmpada que deseja desligar:");
                        int codigo2 = Convert.ToInt32(Console.ReadLine());
                        Lampada.DesligarLampada(codigo2);
                        break;
                    case 4:
                        Lampada.ConsultarPotencia();
                        break;
                    case 5:
                        loop = false;
                        break;
                }
            }

        }
    }
}
