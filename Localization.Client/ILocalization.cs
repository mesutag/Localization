namespace Localization.Client
{
    public interface ILocalization
    {
        ILocalization SetLanguage(string lang);
        LocalizationResolver this[string resourceSet] { get; }
    }
}
