﻿namespace AutoPartsWeb.Infrastructure.DataConstants
{
    public class ValidationConstants
    {
        //Category
        public const int CategoryMinNameLength = 4;
        public const int CategoryMaxNameLength = 50;

        //Manufacturer
        public const int ManufacturerMinNameLength = 3;
        public const int ManufacturerMaxNameLength = 30;
        public const int ManufacturerMinCountryLength = 3;
        public const int ManufacturerMaxCountryLength = 20;

        //Product
        public const int ProductMinNameLength = 3;
        public const int ProductMaxNameLength = 25;
        public const int ProductDescriptionMinLength = 5;
        public const int ProductDescriptionMaxLength = 500;

        //Rating
        public const int MinRatingValue = 1;
        public const int MaxRatingValue = 5;

        //Dealer
        public const int DealerMinNameLength = 3;
        public const int DealerMaxNameLength = 50;

        public const int DealerCompanyNameMinLength = 5;
        public const int DealerCompanyNameMaxLength = 100;

        public const int DealerCompanyNumberMinLength = 10;
        public const int DealerCompanyNumberMaxLength = 25;

        public const int DealerDescriptionMinLength = 15;
        public const int DealerDescriptionMaxLength = 500;

        public const string DealerRequiredErrorMessage = "The {0} field is required";
        public const string DealerStringLenghtErrorMessage = "The {0} field must be {2} and {1} characters long";

        //DateTime
        public const string DateTimeFormat = "dd/MM/yyyy HH:mm";
    }
}
