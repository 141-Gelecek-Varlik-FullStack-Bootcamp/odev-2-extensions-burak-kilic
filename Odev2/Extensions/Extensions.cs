using System.Globalization;

namespace Odev2.Extensions
{
    public class Extension
    {
        public static string LirasToDollars(decimal liras)
        {
            const decimal dollarExcangeRate = 13.73m;
            var lirasStr = liras.ToString("C2", CultureInfo.CreateSpecificCulture("tr-TR"));
            var dollar = liras / dollarExcangeRate;
            var dollarStr = dollar.ToString("C2", CultureInfo.CreateSpecificCulture("us-US");
            return $"{lirasStr} = {dollarStr}";
        } 
    }
}