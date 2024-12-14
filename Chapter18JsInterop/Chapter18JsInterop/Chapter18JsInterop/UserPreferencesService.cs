using Microsoft.AspNetCore.Components;

namespace Chapter18JsInterop;

public class UserPreferencesService : IUserPreferencesService
{
    public string Theme { get; private set; } = "Light";
    public void SetTheme(string theme)
    {
        Theme = theme;
        NotifyStateChanged();
    }
    // Event to notify components when the state changes
    public event Action OnChange;

    private void NotifyStateChanged()
    {
        Dispatcher.CreateDefault().InvokeAsync(OnChange);
    }
}


