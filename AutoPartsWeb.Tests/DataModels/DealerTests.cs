namespace AutoPartsWeb.Tests.DataModels
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using AutoPartsWeb.Infrastructure.DataConstants;
    using System.ComponentModel.DataAnnotations;

    [TestFixture]
    public class DealerTests
    {
        [Test]
        public void Dealer_ShouldHaveKeyAttributeOnIdProperty()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.Id));

            var hasKeyAttribute = property.GetCustomAttributes(typeof(KeyAttribute), false).Any();

            Assert.That(hasKeyAttribute, Is.True);
        }

        [Test]
        public void Dealer_Name_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.Name));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Dealer_Name_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.Name));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.DealerMaxNameLength));
        }

        [Test]
        public void Dealer_CompanyName_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.CompanyName));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Dealer_CompanyName_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.CompanyName));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.DealerCompanyNameMaxLength));
        }

        [Test]
        public void Dealer_CompanyNumber_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.CompanyNumber));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Dealer_CompanyNumber_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.CompanyNumber));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.DealerCompanyNumberMaxLength));
        }

        [Test]
        public void Dealer_Description_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Dealer).GetProperty(nameof(Dealer.Description));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.DealerDescriptionMaxLength));
        }

        [Test]
        public void Dealer_Products_ShouldBeInitialized()
        {
            var dealer = new Dealer();

            var products = dealer.Products;

            Assert.That(products, Is.Not.Null);
            Assert.That(products, Is.InstanceOf<ICollection<Product>>());
        }

        [Test]
        public void Dealer_Orders_ShouldBeInitialized()
        {
            var dealer = new Dealer();

            var orders = dealer.Orders;

            Assert.That(orders, Is.Not.Null);
            Assert.That(orders, Is.InstanceOf<ICollection<Order>>());
        }
    }
}
