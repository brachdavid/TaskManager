using System.ComponentModel.DataAnnotations;

namespace TaskManager.Utilities.Enums
{
    /// <summary>
    /// Industry options in which the advertising agency's client can operate.
    /// </summary>
    public enum Industry
    {
        /// <summary>
        /// IT and technology companies.
        /// </summary>
        [Display(Name = "Information Technology")]
        Technology = 1,

        /// <summary>
        /// Financial sector (banks, investment companies).
        /// </summary>
        [Display(Name = "Finance")]
        Finance = 2,

        /// <summary>
        /// Healthcare (hospitals, clinics, pharmaceutical companies).
        /// </summary>
        [Display(Name = "Healthcare Services")]
        Healthcare = 3,

        /// <summary>
        /// Retail companies (brick-and-mortar stores, e-commerce).
        /// </summary>
        [Display(Name = "Retail")]
        Retail = 4,

        /// <summary>
        /// Education (schools, universities, online education platforms).
        /// </summary>
        [Display(Name = "Education")]
        Education = 5,

        /// <summary>
        /// Real estate (real estate agencies, development companies).
        /// </summary>
        [Display(Name = "Real Estate")]
        RealEstate = 6,

        /// <summary>
        /// Manufacturing industry (factories, manufacturing plants).
        /// </summary>
        [Display(Name = "Manufacturing Industry")]
        Manufacturing = 7,

        /// <summary>
        /// Automotive industry (car manufacturers, auto repair shops).
        /// </summary>
        [Display(Name = "Automotive")]
        Automotive = 8,

        /// <summary>
        /// Food industry (restaurants, food and beverage manufacturers).
        /// </summary>
        [Display(Name = "Food & Beverage")]
        FoodAndBeverage = 9,

        /// <summary>
        /// Hospitality and tourism (hotels, travel agencies).
        /// </summary>
        [Display(Name = "Hospitality & Tourism")]
        Hospitality = 10,

        /// <summary>
        /// Legal services (law firms, notary services).
        /// </summary>
        [Display(Name = "Legal Services")]
        Legal = 11,

        /// <summary>
        /// Non-profit sector (foundations, charitable organizations).
        /// </summary>
        [Display(Name = "Non-Profit")]
        NonProfit = 12,

        /// <summary>
        /// Public sector (government and state institutions).
        /// </summary>
        [Display(Name = "Government")]
        Government = 13,

        /// <summary>
        /// Telecommunications companies (operators, internet providers).
        /// </summary>
        [Display(Name = "Telecommunications")]
        Telecommunications = 14,

        /// <summary>
        /// Industry not corresponding to any of the above options.
        /// </summary>
        [Display(Name = "Other")]
        Other = 15
    }
}
