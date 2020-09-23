using Advisor;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = AdviceMenu.MainMenu();
            }
        }
    }
}
