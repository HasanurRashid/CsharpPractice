using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAnd_InstaceClasses
{
    public class Circle
    {
        public static float _pi;
        int _radious;
        static Circle()
        {
            _pi = 3.14f;
        }
        public Circle(int radious)
        {
            this._radious = radious;
        }

        public float CircleArea()
        {
            return _pi * _radious * _radious;
        }

        public static void Doo()
        {
          throw new NotImplementedException();
        }

    }
}
