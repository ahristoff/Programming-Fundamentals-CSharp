using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Bottom => Top - Height;
        //public int Botton
        //{
        //    get
        //    {
        //        return Top - Height;        
        //    }
        //}
        public double Right => Left + Width;     
    }
}
