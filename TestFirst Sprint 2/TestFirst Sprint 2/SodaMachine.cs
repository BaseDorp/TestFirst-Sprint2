using System;
using System.Collections.Generic;
using System.Text;

namespace TestFirst_Sprint_2
{
    public class SodaMachine
    {
        public SodaMachine()
        {
            
        }

        List<Soda> SodaList = new List<Soda>();

        public string TakeSoda(Soda soda)
        {
            if (SodaList.Contains(soda))
            {
                return $"You have taken {soda} from the machine\n";
            }
            else
            {
                return $"The machine does not contain {soda}\n";
            }
        }

        public string AddSoda(Soda soda)
        {
            SodaList.Add(soda);
            return $"{soda} has been added";
        }

        public string ShowSodas()
        {
            if (SodaList.Count == 0)
            {
                return $"There are no soda in the machine\n";
            }
            else
            {
                string sodaString = $"{this} contains ";
                foreach (Soda soda in SodaList)
                {
                    sodaString += $"{soda}, ";
                }
                return sodaString += "\n";
            }
        }
    }
}
