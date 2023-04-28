using System;

namespace projetoIII
{
    internal class NewBaseType
    {
        private static void Main()
        {
            Main(ObterSeEhFeminino(), GetEhNatal());
        }

        private static bool GetEhNatal()
        {
            return ObterSeEhNatal();
        }

        private static void Main(bool ehFeminino, bool ehNatal) => Main(ehFeminino, ehNatal);

        static void Main(bool ehFeminino, bool ehNatal, bool ehLivroPoemas)
        {
            bool temNotebook = ObterSeTemNotebook();
            bool ehMasculino = ObterSeEhMasculino();
           
           Console.WriteLine("Masculino - 1");
           

         ehMasculino = bool.Parse(Console.ReadLine());
            if (temNotebook && ehMasculino)
            {
                Console.WriteLine("O livro científico-tecnológico pode ser vendido com 95% de certeza.");
            }
            else
            {
                Console.WriteLine("O livro científico-tecnológico não pode ser vendido com 95% de certeza.");
            }

            bool temFilhos = ObterSeTemFilhos();
                    
                    Console.WriteLine("Femenino - 2");
                if (ObterSeEhFeminino() && !temFilhos)
                {
                    Console.WriteLine("A mulher comprou um livro romântico em 100% dos casos.");
                }
                else
                {
                    Console.WriteLine("A mulher não comprou um livro romântico em 100% dos casos.");
                }

            string tituloLivro = ObterTituloLivro();
                bool ehPolicial = ObterSeEhPolicial();

                if (ObterSeEhNatal() && ehPolicial && (tituloLivro == "Vida" || tituloLivro == "Anjos"))
                {
                    double probabilidadeVenda = 0.8;
                    if (new Random().NextDouble() < probabilidadeVenda)
                    {
                        Console.WriteLine("O livro será vendido com 80% de probabilidade.");
                    }
                    else
                    {
                        Console.WriteLine("O livro não será vendido com 20% de probabilidade.");
                    }
                }
                else
                {
                    Console.WriteLine("O livro não será vendido durante o período de Natal ou não atende aos critérios.");
                }
                    bool ehDiaDasMaes = ObterSeEhDiaDasMaes();
                    if (ehDiaDasMaes || ObterSeEhNatal() || ObterSeEhFeminino())
                        {
                            double probabilidadeCompra = 0.2;
                            if (new Random().NextDouble() < probabilidadeCompra)
                            {
                                Console.WriteLine("O livro de poemas será adquirido com 20% de probabilidade.");
                            }
                            else
                            {
                                Console.WriteLine("O livro de poemas não será adquirido com 80% de probabilidade.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("O livro de poemas não atende aos critérios de compra.");
                        }
                        bool ehLivroRomantico = ObterSeEhLivroRomantico();

            if (ehLivroRomantico || ObterSeEhLivroPoemas())
                        {
                            double probabilidadeLiterario = 0.9;
                            if (new Random().NextDouble() < probabilidadeLiterario)
                            {
                                Console.WriteLine("O livro é considerado literário com 90% de probabilidade.");
                            }
                            else
                            {
                                Console.WriteLine("O livro não é considerado literário com 10% de probabilidade.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("O livro não é um livro romântico ou de poemas.");
                        }
                        

                            }

        private static bool ObterSeTituloVidaOuAnjos()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSePossuiFilhos()
        {
            throw new NotImplementedException();
        }

        private static void ObterSeEhMulher()
        {
            throw new NotImplementedException();
        }

        private static bool ehTecnologico()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSePossuiNotebook()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhLivroPoemas()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhLivroRomantico()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhDiaDasMaes()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhPolicial()
        {
            throw new NotImplementedException();
        }

        private static string ObterTituloLivro()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhNatal()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeTemFilhos()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhFeminino()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeEhMasculino()
        {
            throw new NotImplementedException();
        }

        private static bool ObterSeTemNotebook()
        {
            throw new NotImplementedException();
        }
    }

    }
    
    
