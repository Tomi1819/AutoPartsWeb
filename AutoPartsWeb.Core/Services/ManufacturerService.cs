namespace AutoPartsWeb.Core.Services
{
    using AutoPartsWeb.Core.Contracts;
    using AutoPartsWeb.Core.Models.Manufacturer;
    using AutoPartsWeb.Infrastructure.Data.Common;
    using AutoPartsWeb.Infrastructure.Data.Models;
    using System.Threading.Tasks;

    public class ManufacturerService : IManufacturerService
    {
        private readonly IRepository repository;

        public ManufacturerService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddManufacturerAsync(ManufacturerFormViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var manufacturer = new Manufacturer()
            {
                Name = model.Name,
                Country = model.Country,
            };

            await repository.AddAsync(manufacturer);
            await repository.SaveChangesAsync();
        }
    }
}
