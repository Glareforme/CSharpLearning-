namespace SpecFlowProject1.Support.DataForTests.Models
{
    internal class ProductParamInCart
    {
        /// <summary>
        /// Model for get parameters from cart page
        /// </summary>
        internal List<string>? Names { get; set; }
        internal List<string>? Quantities { get; set; }
        internal List<string>? Pricies { get; set; }
        internal List<string>? Colors { get; set; }
        internal List<string>? Size { get; set; }
        internal List<string>? TotalPrice { get; set; }

    }
}
