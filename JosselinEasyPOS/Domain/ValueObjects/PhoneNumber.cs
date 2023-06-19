namespace Domain.ValueObjects;

public partial record PhoneNumber
{
    private const int DefaultLenght = 9;

    private const string Pattern = @"^(?:-*\d-*){8}$";

    private PhoneNumber(string value) => Value = value;
    public string Value { get; set;}

    public static PhoneNumber? Create(string value)
    {
        if(string.IsNullOrEmpaty(value) || !PhoneNumberRegex().IsMatch(value) || !PhoneNumberRegex().IsMatch(value.Lenght != DefaultLenght))
        {
            return null;
        }

        return new PhoneNumber(value);

    }

    [GeneratedRegex(Pattern)]
    private static parcial Relex PhoneNumberRegex();


}