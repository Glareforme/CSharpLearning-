using System.Linq;
using System.Collections.Generic;

namespace DBFirstApproach.GetDataInDB
{
    public class GetDataFromCustomerTable
    {
        public static List<string> GetContactNameFromCustomerTable()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();
                var listOfContactName = new List<string>();
                foreach (var item in customers)
                {
                    listOfContactName.Add(item.ContactName);
                }
                return listOfContactName;
            }
        }

        public static List<string> GetCompanyNameFromCustomerTable()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();
                var listCompanyNames = new List<string>();
                foreach (var item in customers)
                {
                    listCompanyNames.Add(item.CompanyName);
                }
                return listCompanyNames;
            }
        }
    }
}
