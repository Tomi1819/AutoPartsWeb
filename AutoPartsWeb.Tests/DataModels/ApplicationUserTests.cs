namespace AutoPartsWeb.Tests.DataModels
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using AutoPartsWeb.Infrastructure.DataConstants;
    using System.ComponentModel.DataAnnotations;

    [TestFixture]
    public class ApplicationUserTests
    {
        [Test]
        public void ApplicationUser_ShouldHaveRequiredAttributeOnFirstNameProperty()
        {
            var property = typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.FirstName));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void ApplicationUser_FirstName_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.FirstName));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.UserFirstNameMaxLength));
        }

        [Test]
        public void ApplicationUser_ShouldHaveRequiredAttributeOnLastNameProperty()
        {
            var property = typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.LastName));

            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault() as RequiredAttribute;

            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void ApplicationUser_LastName_ShouldHaveMaxLengthAttribute()
        {
            var property = typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.LastName));

            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault() as MaxLengthAttribute;

            Assert.That(maxLengthAttribute, Is.Not.Null);
            Assert.That(maxLengthAttribute.Length, Is.EqualTo(ValidationConstants.UserLastNameMaxLength));
        }
    }
}
