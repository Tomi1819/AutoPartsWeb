namespace AutoPartsWeb.Tests.DataCommon
{
    using AutoPartsWeb.Data;
    using AutoPartsWeb.Infrastructure.Data.Common;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    [TestFixture]
    public class RepositoryTests
    {
        private AutoPartsWebDbContext dbContext;
        private IRepository repository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AutoPartsWebDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            dbContext = new AutoPartsWebDbContext(options);
            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var product = new Product { Name = "Test Product" };

            await repository.AddAsync(product);
            await dbContext.SaveChangesAsync();

            var result = await dbContext.Products.FirstOrDefaultAsync(p => p.Name == "Test Product");
            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Test Product"));
        }

        [Test]
        public async Task GetByIdAsync_ShouldReturnEntity()
        {
            var product = new Product { Name = "Test Product" };
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            var result = await repository.GetByIdAsync<Product>(product.Id);

            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Test Product"));
        }

        [Test]
        public async Task SaveChangesAsync_ShouldSaveChanges()
        {
            var product = new Product { Name = "Test Product" };
            await repository.AddAsync(product);
            await dbContext.SaveChangesAsync();

            product.Name = "Updated Test Product";
            await repository.SaveChangesAsync();

            var result = await dbContext.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Updated Test Product"));
        }
    }
}
