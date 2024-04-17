namespace AutoPartsWeb.Tests.DataModels
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using System.ComponentModel.DataAnnotations;
    using RangeAttribute = System.ComponentModel.DataAnnotations.RangeAttribute;

    public class RatingTests
    {
        [Test]
        public void Rating_ShouldHaveKeyAttributeOnIdProperty()
        {
            var property = typeof(Rating).GetProperty(nameof(Rating.Id));

            var hasKeyAttribute = property.GetCustomAttributes(typeof(KeyAttribute), false).Any();

            Assert.That(hasKeyAttribute, Is.True);
        }

        [Test]
        public void Rating_Value_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Rating).GetProperty(nameof(Rating.Value));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Rating_Value_ShouldHaveRangeAttribute()
        {
            var property = typeof(Rating).GetProperty(nameof(Rating.Value));

            var rangeAttribute = property.GetCustomAttributes(typeof(RangeAttribute), false).FirstOrDefault() as RangeAttribute;

            Assert.That(rangeAttribute, Is.Not.Null);
            Assert.That(rangeAttribute.Minimum, Is.EqualTo(1));
            Assert.That(rangeAttribute.Maximum, Is.EqualTo(5));
        }

        [Test]
        public void Rating_ProductId_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Rating).GetProperty(nameof(Rating.ProductId));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void Rating_UserId_ShouldHaveRequiredAttribute()
        {
            var property = typeof(Rating).GetProperty(nameof(Rating.UserId));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }
    }
}
