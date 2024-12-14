
namespace Chapter18JsInterop;

public interface IBrowserStorageService
{
    Task Init();
    Task ClearAsync(string storageType);
    Task<T> GetItemAsync<T>(string storageType, string key);
    Task RemoveItemAsync(string storageType, string key);
    Task SetItemAsync(string storageType, string key, object value);
}