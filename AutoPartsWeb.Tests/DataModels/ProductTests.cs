namespace AutoPartsWeb.Tests.DataModels
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProductTests
    {
        [Test]
        public void Product_ShouldHaveKeyAttributeOnIdProperty()
        {
            var property = typeof(Product).GetProperty(nameof(Product.Id));

            var hasKeyAttribute = property.GetCustomAttributes(typeof(KeyAttribute), false).Any();

            Assert.That(hasKeyAttribute, Is.True);
        }

        [Test]
        public void Product_Name_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Product).GetProperty(nameof(Product.Name));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Product_Name_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Product).GetProperty(nameof(Product.Name));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(25));
        }

        [Test]
        public void Product_Description_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Product).GetProperty(nameof(Product.Description));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(500));
        }

        [Test]
        public void Product_Price_ShouldHaveColumnAttributeWithTypeDecimal()
        {
            var property = typeof(Product).GetProperty(nameof(Product.Price));

            var columnAttribute = property.GetCustomAttributes(typeof(ColumnAttribute), false).FirstOrDefault() as ColumnAttribute;

            Assert.That(columnAttribute, Is.Not.Null);
            Assert.That(columnAttribute.TypeName, Is.EqualTo("decimal(18,2)"));
        }
    }
}
