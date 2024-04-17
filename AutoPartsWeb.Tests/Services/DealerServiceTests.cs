namespace AutoPartsWeb.Tests.Services
{
    using AutoPartsWeb.Core.Models.Dealer;
    using AutoPartsWeb.Core.Services;
    using AutoPartsWeb.Infrastructure.Data.Common;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Moq;

    [TestFixture]
    public class DealerServiceTests
    {

        [Test]
        public async Task CreateDealerAsync_Should_Add_Dealer_To_Repository()
        {
            var model = new DealerFormViewModel
            {
                Name = "TestDealer",
                CompanyName = "TestCompany",
                CompanyNumber = "123456",
                Description = "TestDescription",
                UserId = "testUserId"
            };
            var mockRepository = new Mock<IRepository>();
            var dealerService = new DealerService(mockRepository.Object);

            await dealerService.CreateDealerAsync(model);

            mockRepository.Verify(repo => repo.AddAsync(It.IsAny<Dealer>()), Times.Once);
            mockRepository.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }
    }
}
