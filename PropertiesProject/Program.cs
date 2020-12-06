using System;

namespace ООП
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100, 50);

            Renderer renderer = new Renderer();
            renderer.Render(player);

        }
    }

    class Player
    {
        public int X { get; }
        public int Y { get; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Renderer
    {
        public void Render(Player player)
        {
            Console.SetCursorPosition(player.X, player.Y);
            Console.Write('@');
        }
    }
}