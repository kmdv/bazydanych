namespace EnterpriseTraining.FieldEditing
{
    public interface IFieldParser
    {
        string ParseMandatoryString(string value);

        int ParseMandatoryInt(string value);

        decimal ParseMandatoryDecimal(string value);

        string ParseOptionalString(string value);

        int? ParseOptionalInt(string value);

        decimal? ParseOptionalDecimal(string value);
    }
}
