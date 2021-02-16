using System;
using System.Collections.Generic;
using System.Text;

namespace TestFirst_Sprint_2
{
    public class Soda
    {

        string flavor;
        float ounces;

        public Soda()
        {
            flavor = "not";
            ounces = 0;
        }

        public Soda(string Flavor)
        {
            flavor = Flavor;
            ounces = 0;
        }

        public Soda(string Flavor, float Ounces)
        {
            flavor = Flavor;
            ounces = Ounces;
        }

        public string About()
        {
            return $"This {this} is {flavor} flavored and is {ounces} FLOZ\n";
        }

    }
}
