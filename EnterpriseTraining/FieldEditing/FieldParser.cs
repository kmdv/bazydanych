using System.Globalization;
namespace EnterpriseTraining.FieldEditing
{
    public sealed class FieldParser : IFieldParser
    {
        public string ParseMandatoryString(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
        }

        public int ParseMandatoryInt(string value)
        {
            return int.Parse(value);
        }

        public decimal ParseMandatoryDecimal(string value)
        {
            return decimal.Parse(value, CultureInfo.InvariantCulture);
        }

        public string ParseOptionalString(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        public int? ParseOptionalInt(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null as int? : int.Parse(value);
        }

        public decimal? ParseOptionalDecimal(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null as decimal? : decimal.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
