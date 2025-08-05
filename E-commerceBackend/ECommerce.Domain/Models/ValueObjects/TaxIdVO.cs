using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Models.ValueObjects
{
    public class TaxIdVO
    {
        public TaxIdVO(string taxId)
        {
            if (!IsValidFormat(taxId))
                throw new Exception("The TaxId format is incorrect");
        }

        public string TaxId { get; set; }

        public static bool IsValidFormat(string isValidTaxId)
        {
            return !string.IsNullOrWhiteSpace(isValidTaxId) && isValidTaxId.Length == 11 && isValidTaxId.All(char.IsDigit);
        }
    }
}
