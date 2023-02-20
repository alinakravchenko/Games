using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDll
{
    public class GamesClass
    {
        public int Id { get; set; }
       public string Name { get; set; }
        public string Creator { get; set; }
       public string Genre { get; set; }
       public DateTime Date { get; set; }


        public GamesClass() { } 
    }
}
