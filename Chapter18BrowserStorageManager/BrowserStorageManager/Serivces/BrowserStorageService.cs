using Microsoft.JSInterop;
using System.Text.Json;

namespace BrowserStorageManager.Serivces;
public class BrowserStorageService : IBrowserStorageService
{
    private readonly IJSRuntime jsRuntime;
    private IJSObjectReference moduleTask = null;

    public BrowserStorageService(IJSRuntime jsRuntime)
        => this.jsRuntime = jsRuntime;

    public async Task Init()
        => moduleTask = await jsRuntime
             .InvokeAsync<IJSObjectReference>
                  ("import", "./browserStorage.js");

    public async Task SetItemAsync
              (string storageType, string key, object value)
        => await moduleTask.InvokeVoidAsync("setItem"
            , storageType, key
            , JsonSerializer.Serialize(value));

    public async Task<T?> GetItemAsync<T>
              (string storageType, string key)
    {
        var jsonValue = await moduleTask.InvokeAsync<string>
                ("getItem", storageType, key);
        return jsonValue == null
              ? default
              : JsonSerializer.Deserialize<T>(jsonValue);
    }

    public async Task RemoveItemAsync
              (string storageType, string key)
        => await moduleTask.InvokeVoidAsync
                  ("removeItem", storageType, key);

    public async Task ClearAsync(string storageType)
        => await moduleTask.InvokeVoidAsync("clear", storageType);
}
