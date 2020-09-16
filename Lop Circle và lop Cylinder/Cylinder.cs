using System;
using System.Collections.Generic;
using System.Text;

namespace Lop_Circle_và_lop_Cylinder
{
    public class Cylinder : Circle
    {
        private double Height;

        public Cylinder(double _Height,double R, string Color):base(R,Color)
        {
            Height = _Height;
        }
        public Cylinder()
        {

        }

        public void setHeight(double _Height)
        {
            Height = _Height;
        }
        public double getHeight()
        {
            return Height;
        }
        
        public double Volume()
        {
            return Area * Height;
        }
        public override string ToString()
        {
            return"Height = "+ getHeight() + " The tich = "+ Volume() + base.ToString();
        }
    }
}
