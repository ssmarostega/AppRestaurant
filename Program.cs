using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantePedido
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exibindo o cardápio
            Console.WriteLine("Digite o periodo (manha ou noite) e seu pedido conforme exemplo: (manha,1,2,3");
            Console.WriteLine("Opcções de Menu");
            Console.WriteLine("Manhã: (1)Ovos, (2)Torrada, (3)Café");
            Console.WriteLine("Noite: (1)Carne, (2)Batata, (3)Vinho, (4)Torta");

            //Lendo a opção do usuário
            string stringOpcoes = Console.ReadLine();
            string[] opcoes = stringOpcoes.Split(',');

            //opcoes[0] = opcoes[0].ToLower();

            string resultado = string.Empty; ;
            if (opcoes[0].ToLower() == "manha")
            {
                bool ovos = false;
                bool torrada = false;
                int cafe = 0;
                resultado = resultado + "manha";
                for (int i = 1; i < opcoes.Length; i++)
                {
                    if (opcoes[i] == "1")
                    { //Ovos
                        if (ovos == false)
                        { //Se ainda não tinha ovos
                            ovos = true;
                        }
                    }
                    if (opcoes[i] == "2")
                    { //Torrada
                        if (torrada == false)
                        { //Se ainda não tinha torrada
                            torrada = true;
                        }
                    }
                    if (opcoes[i] == "3")
                    { //Cafe
                        cafe++;
                    }
                }

                //imprimindo resultados
                if (ovos)
                {
                    resultado = resultado + ", ovos";
                }
                if (torrada)
                {
                    resultado = resultado + ", torrada";
                }
                if (cafe > 0)
                {
                    resultado = resultado + ", café(" + cafe + "x)";
                }
                
            }
            else if (opcoes[0].ToLower() == "noite")
            {

                bool carne = false;
                bool vinho = false;
                bool torta = false;
                int batata = 0;
                resultado = resultado + "noite";
                for (int i = 1; i < opcoes.Length; i++)
                {
                    if (opcoes[i] == "1")
                    { //Carne
                        if (carne == false)
                        { //Se ainda não tinha carne
                            carne = true;
                        }
                    }
                    if (opcoes[i] == "2")
                    { //Batata
                        batata++;
                    }
                    if (opcoes[i] == "3")
                    { //Vinho
                        if (vinho == false)
                        { //Se ainda não tinha vinho
                            vinho = true;
                        }
                    }
                    if (opcoes[i] == "4")
                    { //torta
                        if (torta == false)
                        { //Se ainda não tinha torta
                            torta = true;
                        }
                    }
                }

                //imprimindo resultados
                if (carne)
                {
                    resultado = resultado + ", carne";
                }
                if (batata > 0)
                {
                    resultado = resultado + ", batata(" + batata + "x)";
                }
                if (vinho)
                {
                    resultado = resultado + ", vinho";
                }
                if (torta)
                {
                    resultado = resultado + ", torta";
                }

            }
            else
            {
                resultado = "erro";
            }

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
