using System;
using System.Globalization;

namespace EnterpriseTraining.FieldEditing
{
    public sealed class FieldStringizer : IFieldStringizer
    {
        public string GetMandatoryString(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            return value;
        }

        public string GetMandatoryInt(int value)
        {
            return string.Format("{0:d}", value);
        }

        public string GetMandatoryDecimal(decimal value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public string GetOptionalString(string value)
        {
            return value == null ? string.Empty : value;
        }

        public string GetOptionalInt(int? value)
        {
            if (value != null)
            {
                return string.Format("{0:d}", value.Value);
            }

            return string.Empty;
        }

        public string GetOptionalDecimal(decimal? value)
        {
            return value == null ? string.Empty : value.Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
