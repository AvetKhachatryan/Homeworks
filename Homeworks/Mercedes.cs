using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    public class Mercedes //2018
    {
        string[] Amodels = { "A180", "A200", "A220" };
        string[] Bmodels = { "B180", "B200", "B250" };
        string[] Cmodels = { "C180", "C200", "C300", "C400" };
        string[] Emodels = { "E200", "E300", "E400", "E500" };
        string[] Smodels = { "S500", "S550",};
        string[] BodyTypes = { "sedan", "universal", "coupe", "hatchback" };
        char[] Classes = { 'c', 'd', 'e', 'f' };


        public char Class;
        public string engine;       //volume & type

        public short HorsePower;
        public short NewtonMeter;
        public short weigth;

        public float length;        //in milimeters
        public float width;
        public float heigth;
        public float wheelBase;

        public float Acceler100;
        public float fuelCons;
        public Mercedes(string Model, string BodyType) 
        { 
            if(Amodels.Contains(Model))
            {
                Class = 'c';
                width = 1796;
                wheelBase = 2729;
                if (BodyType == "hatchback")
                {
                    heigth = 1440;
                    length = 4419;
                }
                else if (BodyType == "sedan")
                {
                    heigth = 1446;
                    length = 4549;
                }
                else { Console.WriteLine("chka tenc kuzov"); }
            }
            if (Bmodels.Contains(Model))
            {
                Class = 'd';
                if (BodyType == "hatchback")
                {
                    width = 1795;
                    heigth = 1562;
                    wheelBase = 2729;
                }
                else { Console.WriteLine("chka tenc kuzov"); }
            }
            if (Cmodels.Contains(Model))
            {
                Class = 'd';
                if (BodyType == "sedan" || BodyType == "universal")
                {
                    width = 1810;
                    heigth = 1457;
                    wheelBase = 2840;
                    length = 4702;
                }
                else if(BodyType == "coupe")
                {
                    width = 1877;
                    heigth = 1400;
                    wheelBase = 2840;
                    length = 4581;
                }
                else { Console.WriteLine("chka tenc kuzov"); }
            }
            if (Emodels.Contains(Model))
            {
                Class = 'e';
                wheelBase = 2939;
                length = 4923;
                if(BodyType == "sedan" || BodyType == "universal")
                {
                    width = 1852;
                    heigth = 1468;
                }
                else if (BodyType == "coupe")
                {
                    width = 1860;
                    heigth = 1430;
                }
                else { Console.WriteLine("chka tenc kuzov"); }
            }
            if (Smodels.Contains(Model))
            {
                Class = 'f';
                if (BodyType == "sedan")
                {
                    width = 1899;
                    heigth = 1494;
                    wheelBase = 3035;
                    length = 5246;
                }
                else { Console.WriteLine("chka tenc kuzov"); }
            }
        }
        public bool isMoving()
        {
            return true;
        }
        public bool isFast(string Model)
        {
            if (Model.Contains("400") || Model.Contains("500") || Model.Contains("550"))
            {
                return true;
            }
            return false;
        }
        public bool isComfy(string Model)
        {
            if(Model.Contains("E") || Model.Contains("S"))
            {
                return true;
            }
            return false;
        }
        public bool isCompact(string Model)
        {
            if(Model.Contains("A") || Model.Contains("B") || Model.Contains("C"))
            {
                return true;
            }
            return false;
        }
    }
}
