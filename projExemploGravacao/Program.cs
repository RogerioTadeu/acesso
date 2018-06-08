using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace projExemploGravacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNomes = new List<string>();
            int op;

            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Gravar");
                Console.WriteLine("2. Ler");
                Console.WriteLine("3. Listar");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            StreamWriter arqout = new StreamWriter("nomes.txt");
                            foreach (string s in listaNomes)
                                arqout.WriteLine(s);
                            arqout.Close();
                            break;
                        }
                    case 2:
                        {
                            if (File.Exists("nomes.txt"))
                            {
                                StreamReader arqin = new StreamReader("nomes.txt");
                                while (!arqin.EndOfStream)
                                {
                                    listaNomes.Add(arqin.ReadLine());
                                }
                                arqin.Close();
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (string s in listaNomes)
                                Console.WriteLine(s);
                            Console.WriteLine("--------------");
                            break;
                        }
                }
            }
            while (op != 0);
        }
    }
}
