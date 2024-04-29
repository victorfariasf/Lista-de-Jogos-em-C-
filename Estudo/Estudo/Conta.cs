using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Conta
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private string _password;

        List<Game> games = new List<Game>();

        public Conta(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Conta(string name, string password)
        {
            Name = name;
            Password = password;
        }


        public string Password
        {
            get { return _password; }
            set {
                if (value.Length < 3)
                {
                    Console.WriteLine("Erro na senha tente novamente");
                }
                else
                {
                    _password = value;
                }
            }
        }

        public override string ToString()
        {
            return "Nome: " + Name + "\nEmail: " + Email + "\nSenha: " + Password;
        }

        public void menu()
        {
            int controlador;
            do
            {
                Console.WriteLine("1. Cadastrar Jogo\n2. Lista de Jogos\n3. Editar Jogos\n4. Sair\n5. Remover jogos");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        putGame();
                        break;
                    case 2:
                        listGame();
                        break;
                    case 3:
                        editGame();
                        break;
                    case 4:
                        return;
                        break;
                    case 5:
                        removeGame();
                        break;
                    default:
                        Console.WriteLine("opção inválida");
                        break;
                }
                Console.WriteLine("Deseja encerrar?\n1. Sim\n2. Não");
                controlador = int.Parse(Console.ReadLine());
            } while (controlador != 1);
        }

        private void putGame()
        {
            Console.WriteLine("Qual jogo você deseja inserir?");
            string gameName = Console.ReadLine();
            Console.WriteLine("Qual o gênero dele?");
            string genre = Console.ReadLine();
            Console.WriteLine("Estado do jogo");
            string gameState = Console.ReadLine();

            Game putGame = new Game(gameName, genre, gameState);
            games.Add(putGame);
            Console.ReadLine();
            Console.Clear();
        }

        private void listGame()
        {
            games.Sort((x, y) => string.Compare(x.Name, y.Name));
            foreach (Game game in games)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine(game);
                Console.WriteLine("---------------------------------------------------------");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private void editGame()
        {
            string temp;
            Console.WriteLine("Insira o nome do jogo que deseja editar: ");
            string tempGameName = Console.ReadLine();
            foreach (Game game in games)
            {
                if (game.Name == tempGameName)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine(game);
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("O que deseja mudar?\n1. Nome\n2. Gênero\n3.Estado do jogo\n4. Todos os campos");
                    int opInEdit = int.Parse(Console.ReadLine());
                    switch (opInEdit)
                    {
                        case 1:
                            Console.WriteLine("Insira um novo nome");
                            temp = Console.ReadLine();
                            game.Name = temp;
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Insira um novo gênero");
                            temp = Console.ReadLine();
                            game.Genre = temp;
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Insira um novo Estado de Jogo");
                            temp = Console.ReadLine();
                            game.GameState = temp;
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Insira um novo nome");
                            string tempN = Console.ReadLine();
                            Console.WriteLine("Insira um novo gênero");
                            string tempG = Console.ReadLine();
                            Console.WriteLine("Insira um novo Status");
                            string tempS = Console.ReadLine();

                            game.Name = tempN;
                            game.Genre = tempG;
                            game.GameState = tempS;

                            Console.ReadLine();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    Console.WriteLine("Jogo atualizado");
                    Console.WriteLine(game);
                }
                else
                {
                    Console.WriteLine("Jogo não encontrado, verifique se esse jogo existe na sua conta");
                }
            }
        }

        private void removeGame()
        {
            Console.WriteLine("Insira o nome do jogo que você deseja remover");
            string nameTemp = Console.ReadLine();

            int death = games.FindIndex(x => x.Name == nameTemp);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(games[death]);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Deseja remover este jogo? (y/n)");
            char yn = char.Parse(Console.ReadLine());

            if(yn == 'y')
            {
                games.RemoveAt(death);
            }
            else
            {
                Console.WriteLine("Jogo poupado da sua fúria incansável");
            }

            Console.ReadLine();
            Console.Clear();
            listGame();

            
        }
        
    }
}
