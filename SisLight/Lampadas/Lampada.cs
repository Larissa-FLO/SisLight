using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLight.Lampadas
{
    public class Lampada
    {
        public int Codigo { get; set; }
        public int Watts { get; set; }
        public bool Ligada = false;
        public static int UltimoCodigo = 1;

        public static List<Lampada> Lampadas = new();

        public static void LigarLampada(int codigo)
        {
            if (Lampadas.Count > 0)
            {
                foreach (var lampada in Lampadas)
                {
                    if (lampada.Codigo == codigo && lampada.Ligada == true)
                    {
                        Console.WriteLine("A lâmpada já está ligada.");
                    }
                    else if (lampada.Codigo == codigo && lampada.Ligada == false)
                    {
                        lampada.Ligada = true;
                        Console.WriteLine("A lâmpada foi ligada.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Código inválido. Tente novamente.");
            }
        }

        public static void DesligarLampada(int codigo)
        {
            if (Lampadas.Count > 0)
            {
                foreach (var lampada in Lampadas)
                {
                    if (lampada.Codigo == codigo && lampada.Ligada == false)
                    {
                        lampada.Ligada = true;
                        Console.WriteLine("A lâmpada já está desligada.");
                    }
                    else if (lampada.Codigo == codigo && lampada.Ligada == true)
                    {
                        lampada.Ligada = false;
                        Console.WriteLine("A lâmpada foi desligada.");
                    }
                } 
            }
            else
            {
                Console.WriteLine("Código inválido. Tente novamente.");
            }
        }

        public static void CadastrarLampada()
        {
            int i = 0;
           
            while (i < 5)
            {
                Lampada lampada = new Lampada();
                lampada.Codigo = UltimoCodigo;

                Console.WriteLine($"Código: {lampada.Codigo} \nSituação da lâmpada: Desligada.");

                Console.WriteLine("Informe a potência da lâmpada:");
                int watts = Convert.ToInt32(Console.ReadLine());
                lampada.Watts = watts;

                Console.WriteLine("Lâmpada cadastrada com sucesso.");
                Lampadas.Add(lampada);
                UltimoCodigo++;
                i++;
            }
        }

        public static void ConsultarPotencia()
        {
            int totalWatts = 0;

            foreach (var lampada in Lampadas)
            {
                if (lampada.Ligada == true)
                {
                    totalWatts += lampada.Watts;
                }
            }
            if (totalWatts == 0)
            {
                Console.WriteLine("Não há nenhuma lâmpada acesa no momento.");
            }
            else
            {
                Console.WriteLine($"O total de potência utilizada é de {totalWatts} watts.");
            }
        }
    }
}
