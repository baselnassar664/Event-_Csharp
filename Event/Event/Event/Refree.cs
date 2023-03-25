using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Event
{
    internal class Refree
    {
        public string Name { get; set; }

        public override string ToString()
        => $"{Name}";

        //دالة بدها الوكيشن لمن الكورة تغير موقعها
        public void Lock(Location location) => Console.WriteLine($"{this} is lis Looking at {location}");
        // this refer to methode override ToString()


    }
}
