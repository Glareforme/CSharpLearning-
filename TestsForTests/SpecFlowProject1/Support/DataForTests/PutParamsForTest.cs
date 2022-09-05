namespace SpecFlowProject1.Support.DataForTests
{
    internal class PutParamsForTest
    {
        internal List<string> PutNames(string fName, string sName)
        {
            var namesList = new List<string>();
            namesList.Add(sName);
            namesList.Add(fName);
            return namesList;
        }
        internal List<string> PutPrices(string fPrice, string sPrice)
        {
            var priceList = new List<string>();
            priceList.Add(fPrice);
            priceList.Add(sPrice);
            return priceList;
        }
        internal List<string> PutQuantities(string fQuantities, string sQuantities)
        {
            var quantitiesList = new List<string>();
            quantitiesList.Add(fQuantities);
            quantitiesList.Add(sQuantities);
            return quantitiesList;
        }
        internal List<string> PutColors(string fColors, string sColors)
        {
            var colorsList = new List<string>();
            colorsList.Add(fColors);
            colorsList.Add(sColors);
            return colorsList;
        }
        internal List<string> PutSize(string fSize, string sSize)
        {
            var sizeList = new List<string>();
            sizeList.Add(fSize);
            sizeList.Add(sSize);
            return sizeList;
        }
        internal List<string> PutTotalPrice(string fTP, string sTP)
        {
            var totalPriceList = new List<string>();
            totalPriceList.Add(fTP);
            totalPriceList.Add(sTP);
            return totalPriceList;
        }
    }
}
