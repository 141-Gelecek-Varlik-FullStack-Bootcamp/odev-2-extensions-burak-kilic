using System.Globalization;

namespace Odev2.Extensions
{
    public class Extension
    {
        public static string LirasToDollars(decimal liras)
        {
            //Doların değerini sabit değer olarak ata 
            const decimal dollarExcangeRate = 13.73m;

            var dollar = liras / dollarExcangeRate;

            //Para birimlerini sembolleriyle birlikte ve ondalıklı olarak göster
            var lirasStr = liras.ToString("C2", CultureInfo.CreateSpecificCulture("tr-TR"));
            var dollarStr = dollar.ToString("C2", CultureInfo.CreateSpecificCulture("us-US");
            
            return $"{lirasStr} = {dollarStr}";
        } 
    }
}