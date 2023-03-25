using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Event
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;

        public Location Location {
            get => Location;
            set {
                if(value!=location) // علشان اتاكد الكورة اتغير موقعها لموقع جديد
                    location = value;
                OnLocationChanged.Invoke(value);
            }
        }

        public event Action<Location> OnLocationChanged;
        //لمن الكورة تغير موقعها يسمع ع 
        //PLAYER and refree
        //الاعب والحكم
    }
}
