namespace AutoPartsWeb.Infrastructure.DataConstants
{
    internal class ValidationConstants
    {
        //Category
        public const int CategoryMinNameLenght = 4;
        public const int CategoryMaxNameLenght = 50;

        //Manufacturer
        public const int ManufacturerMinNameLenght = 3;
        public const int ManufacturerMaxNameLenght = 30;
        public const int ManufacturerMinCountryLenght = 3;
        public const int ManufacturerMaxCountryLenght = 20;

        //Product
        public const int ProductMinNameLenght = 3;
        public const int ProductMaxNameLenght = 25;
        public const int ProductDescriptionMinLenght = 5;
        public const int ProductDescriptionMaxLenght = 500;

        //Rating
        public const int MinRatingValue = 1;
        public const int MaxRatingValue = 5;
    }
}
