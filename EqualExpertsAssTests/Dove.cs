namespace EqualExpertsAssTests
{
    public class Dove : Product
    {
        public Dove()
        {
            this.unitPrice = 39.99;
            this.name = "Dove Soap";
        }

        public double unitPrice { get ; set; }
        public string name { get; set; }
    }
}
