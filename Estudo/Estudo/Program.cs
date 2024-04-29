namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlador;
            List<Conta> logins = new List<Conta>();
            Console.WriteLine("Sistema de jogos");
            Console.WriteLine("Isso é  um clone");

            
            do
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1. Cadastrar Conta\n2. Entrar");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira um nome de perfil");
                        string name = Console.ReadLine();
                        Console.WriteLine("Insira um email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Insira uma senha");
                        string passoword = Console.ReadLine();

                        Conta criar = new Conta(name, email, passoword);
                        logins.Add(criar);
                        Conta logar = logins.Find(x => x.Name == name && x.Password == passoword);
                        if(logar == null)
                        {
                            Console.WriteLine("Erro na criação da conta");

                        }
                        else
                        {
                            Console.WriteLine(logar);
                            Console.WriteLine("Entrando...");
                            logar.menu();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome e a senha");
                        name = Console.ReadLine();
                        passoword = Console.ReadLine();

                        logar = logins.Find(x => x.Name == name && x.Password == passoword);
                        if(logar == null)
                        {
                            Console.WriteLine("Conta não existente");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(logar);
                            Console.WriteLine("Entrando...");
                            Console.ReadLine();
                            Console.Clear();
                            logar.menu();
                        }
                        
                        break;
                    default:
                        Console.WriteLine();
                        break;

                }

                Console.WriteLine("Deseja encerrar o programa\n1. Sim\n2. Não");
                controlador = int.Parse(Console.ReadLine());
            } while (controlador != 1);
        }
    }
}