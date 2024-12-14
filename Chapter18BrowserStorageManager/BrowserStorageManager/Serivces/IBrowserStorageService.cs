
namespace BrowserStorageManager.Serivces;

public interface IBrowserStorageService
{
    Task ClearAsync(string storageType);
    Task<T?> GetItemAsync<T>(string storageType, string key);
    Task Init();
    Task RemoveItemAsync(string storageType, string key);
    Task SetItemAsync(string storageType, string key, object value);
}