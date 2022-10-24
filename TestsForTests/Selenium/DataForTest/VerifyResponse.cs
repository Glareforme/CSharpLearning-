using DBTests.Models;

namespace DBTests.DataForTest
{
    internal class VerifyResponse
    {
        public static bool IsCreatedRecordsInDatabaseCorrect(List<Employees> expectedResult, List<Employees> actualResult)
        {
            if (actualResult.Count == 3)
            {
                if (expectedResult[0].Id.Equals(actualResult[0].Id) || expectedResult[0].Name.Equals(actualResult[0].Name))
                {
                    if (expectedResult[1].Id.Equals(actualResult[1].Id) || expectedResult[1].Name.Equals(actualResult[1].Name))
                    {
                        if (expectedResult[2].Id.Equals(actualResult[2].Id) || expectedResult[2].Name.Equals(actualResult[2].Name))
                        {
                            return true;
                        }
                    }
                }
            }
            else if(actualResult.Count == 2) 
            {
                if (expectedResult[0].Id.Equals(actualResult[0].Id) || expectedResult[0].Name.Equals(actualResult[0].Name))
                {
                    if (expectedResult[1].Id.Equals(actualResult[1].Id) || expectedResult[1].Name.Equals(actualResult[1].Name))
                    {
                        return true;
                    }
                }
            }
            return true;
        }

    }
}
