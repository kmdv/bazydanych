namespace EnterpriseTraining.FieldEditing
{
    public interface IFieldStringizer
    {
        string GetMandatoryString(string value);

        string GetMandatoryInt(int value);

        string GetMandatoryDecimal(decimal value);

        string GetOptionalString(string value);

        string GetOptionalInt(int? value);

        string GetOptionalDecimal(decimal? value);
    }
}
