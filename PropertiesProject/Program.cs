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
        public int positionX { get; }
        public int positionY { get; }

        public Player(int x, int y)
        {
            positionX = x;
            positionY = y;
        }
    }

    class Renderer
    {
        public void Render(Player player)
        {
            Console.SetCursorPosition(player.positionX, player.positionY);
            Console.Write('@');
        }
    }
}