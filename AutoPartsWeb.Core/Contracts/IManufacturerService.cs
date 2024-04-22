namespace AutoPartsWeb.Core.Contracts
{
    using AutoPartsWeb.Core.Models.Manufacturer;

    public interface IManufacturerService
    {
        Task AddManufacturerAsync(ManufacturerFormViewModel model);
        Task RemoveManufacturerAsync(int manufacturerId);
    }
}
