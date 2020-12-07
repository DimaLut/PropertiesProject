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
        public int PositionX { get; }
        public int PositionY { get; }

        public Player(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }

    class Renderer
    {
        public void Render(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.Write('@');
        }
    }
}