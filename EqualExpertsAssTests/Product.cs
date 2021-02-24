using System;

namespace EqualExpertsAssTests
{
    public interface Product
    {
        Double unitPrice { get; set; }
        string name { get; set; }
    }

    public class Axe : Product
    {
        public double unitPrice { get; set ; }
        public string name { get; set ; }

        public Axe()
        {
            name = "Axe";
            unitPrice = 99.99;
        }
    }
}
