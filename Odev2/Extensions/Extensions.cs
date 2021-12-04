using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Odev2.Extensions
{
    public static class Extension
    {
        public static string LirasToDollars(this decimal liras)
        {
            //Doların değerini sabit değer olarak ata 
            const decimal dollarExcangeRate = 13.73m;

            var dollar = liras / dollarExcangeRate;

            //Para birimlerini sembolleriyle birlikte ve ondalıklı olarak göster
            var lirasStr = liras.ToString("C2", CultureInfo.CreateSpecificCulture("tr-TR"));
            var dollarStr = dollar.ToString("C2", CultureInfo.CreateSpecificCulture("us-US");
            
            return $"{lirasStr} = {dollarStr}";
        }

        public static string GetAccountTypeName(this Enum accountType){
            var result = accountType.GetType().GetMember(accountType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name;
            return result;
        }

    }
}