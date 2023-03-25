using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Event
{
    internal class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        public override string ToString()
        => $"{Name}:{Team}";


        //دالة بدها الوكيشن لمن الكورة تغير موقعها
        public void Run(Location location)
        => Console.WriteLine($"{this} is lis Looking at {location}");

        // this refer to methode override ToString()
    }
}
