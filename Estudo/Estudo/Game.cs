using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Game
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string GameState { get; set; }
        public Game(string name, string genre, string gameState)
        {
            Name = name;
            Genre = genre;
            GameState = gameState;
        }

        public override string ToString()
        {
            return "Nome do Jogo: " + Name + "\nGênero: " + Genre + "\nStatus do Jogo: " + GameState;

        }
    }
}
