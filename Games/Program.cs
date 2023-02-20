using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDll;
using GamesContext;

namespace Gamess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (GamesContextClass gc = new GamesContextClass(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {

                GamesClass game1 = new GamesClass();
                GamesClass game2 = new GamesClass();
                game1.Name = "Doom";
                game1.Creator = "idTech";
                game1.Genre = "action";
                game1.Date = DateTime.Now;

                game2.Name = "Heroes of Might and Magic";
                game2.Creator = "3DO";
                game2.Genre = "strategy";
                game2.Date = DateTime.Now;
                gc.gamesSet.Add(game1);
                gc.gamesSet.Add(game2);
                gc.SaveChanges();
            }
        }
    }
}
