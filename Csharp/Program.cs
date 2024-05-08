using System;
using System.Globalization;
using System.Numerics;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.Process();
            }
        }
    }
}