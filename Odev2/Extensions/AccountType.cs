using System.ComponentModel.DataAnnotations;

namespace Odev2.Extensions
{
    public enum AccountType
    {
        [Display(Name = "Normal Account")]
        AccountType_1 = 1,
        [Display(Name = "Premium Account")]
        AccountType_2 = 2
    }
}