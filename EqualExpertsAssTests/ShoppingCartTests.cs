using NUnit.Framework;
using System.Linq;
using System.Text;

namespace EqualExpertsAssTests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void ShoppingCart_given_we_add_5_dove_cart_should_contain_5_productst_correct_unit_price()
        {
            ShoppingCart cart = sut();
            var TotalPrice = 0.0;
            Dove item = new Dove();
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);

            Assert.That(cart.GetProducts().Count, Is.EqualTo(5));
            Assert.That(cart.GetProducts().All(x => x.name.Equals("Dove Soap") && x.unitPrice == 39.99), Is.True);
            Assert.That(cart.GetTotalPrice(), Is.EqualTo(199.95));


        }

        private static ShoppingCart sut(double vat = 0.0)
        {
            return new ShoppingCart(vat);
        }

        [Test]
        public void ShoppingCart_given_we_add_5_dove_add_add_2_dove_cart_should_contain_8_Dove_with_correct_unit_price_t()
        {
            ShoppingCart cart = sut();
            var TotalPrice = 0.0;
            Dove item = new Dove();
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);

            Assert.That(cart.GetProducts().Count, Is.EqualTo(5));
            Assert.That(cart.GetProducts().All(x => x.name.Equals("Dove Soap") && x.unitPrice == 39.99), Is.True);
            Assert.That(cart.GetTotalPrice(), Is.EqualTo(199.95));

            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item);

            Assert.That(cart.GetProducts().Count, Is.EqualTo(8));
            Assert.That(cart.GetProducts().All(x => x.name.Equals("Dove Soap") && x.unitPrice == 39.99), Is.True);
            Assert.That(cart.GetTotalPrice(), Is.EqualTo(319.92));
        }

        [Test]
        public void ShoppingCart_given_we_add_2_dove_and_add_2_Axe_cart_should_contain_2_Dove_with_correct_unit_price_and_2_Axe_with_correct_unit_price_t()
        {
            ShoppingCart cart = sut(12.5);
            var TotalPrice = 0.0;
            var item = new Dove();
            var item2 = new Axe();
            cart.AddProduct(item);
            cart.AddProduct(item);
            cart.AddProduct(item2);
            cart.AddProduct(item2);



            Assert.That(cart.GetProducts().Count, Is.EqualTo(4));
            Assert.That(cart.GetProducts().Where(x => x.name.Equals("Dove Soap") && x.unitPrice == 39.99).Count, Is.EqualTo(2));
            Assert.That(cart.GetProducts().Where(x => x.name.Equals("Axe") && x.unitPrice == 99.99).Count, Is.EqualTo(2));
            Assert.That(cart.GetVat(), Is.EqualTo(35.00));
            Assert.That(cart.GetTotalPrice(), Is.EqualTo(314.96));
            
        }
    }
}
