
namespace Chapter18JsInterop;

public interface IUserPreferencesService
{
    string Theme { get; }

    event Action OnChange;

    void SetTheme(string theme);
}