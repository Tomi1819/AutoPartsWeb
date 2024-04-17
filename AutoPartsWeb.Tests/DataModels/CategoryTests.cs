namespace AutoPartsWeb.Tests.DataModels
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using AutoPartsWeb.Infrastructure.DataConstants;
    using System.ComponentModel.DataAnnotations;

    [TestFixture]
    public class CategoryTests
    {
        [Test]
        public void Category_ShouldHaveKeyAttributeOnIdProperty()
        {
            var property = typeof(Category).GetProperty(nameof(Category.Id));

            var hasKeyAttribute = property.GetCustomAttributes(typeof(KeyAttribute), false).Any();

            Assert.That(hasKeyAttribute, Is.True);
        }

        [Test]
        public void Category_Name_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Category).GetProperty(nameof(Category.Name));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Category_Name_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(Category).GetProperty(nameof(Category.Name));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.CategoryMaxNameLength));
        }

        [Test]
        public void Category_Products_ShouldBeInitialized()
        {
            var category = new Category();

            var products = category.Products;

            Assert.That(products, Is.Not.Null);
            Assert.That(products, Is.InstanceOf<ICollection<Product>>());
        }
    }
}
