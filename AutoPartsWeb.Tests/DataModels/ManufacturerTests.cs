using AutoPartsWeb.Infrastructure.Data.Models;
using AutoPartsWeb.Infrastructure.DataConstants;
using System.ComponentModel.DataAnnotations;

namespace AutoPartsWeb.Tests.DataModels
{
    [TestFixture]
    public class ManufacturerTests
    {
        [Test]
        public void Manufacturer_ShouldHaveKeyAttributeOnIdProperty()
        {
            var property = typeof(Manufacturer).GetProperty(nameof(Manufacturer.Id));

            var hasKeyAttribute = property.GetCustomAttributes(typeof(KeyAttribute), false).Any();

            Assert.IsTrue(hasKeyAttribute);
        }

        [Test]
        public void Manufacturer_Name_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Manufacturer).GetProperty(nameof(Manufacturer.Name));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Manufacturer_Name_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Manufacturer).GetProperty(nameof(Manufacturer.Name));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.ManufacturerMaxNameLength));
        }

        [Test]
        public void Manufacturer_Country_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Manufacturer).GetProperty(nameof(Manufacturer.Country));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Manufacturer_Country_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Manufacturer).GetProperty(nameof(Manufacturer.Country));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.ManufacturerMaxCountryLength));
        }

        [Test]
        public void Manufacturer_Products_ShouldBeInitialized()
        {
            var manufacturer = new Manufacturer();

            var products = manufacturer.Products;

            Assert.That(products, Is.Not.Null);
            Assert.That(products, Is.InstanceOf<ICollection<Product>>());
        }
    }
}
