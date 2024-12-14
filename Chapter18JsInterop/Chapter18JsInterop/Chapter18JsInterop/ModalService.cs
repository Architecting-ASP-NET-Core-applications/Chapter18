using Microsoft.JSInterop;

namespace Chapter18JsInterop;

public class ModalService : IAsyncDisposable, IModalService
{
    private readonly IJSRuntime jsRuntime;
    private IJSObjectReference? module = null;
    public ModalService(IJSRuntime jsRuntime) 
        => this.jsRuntime = jsRuntime;
    public async Task Init()
    {
        if(module is null)
            module = await jsRuntime.InvokeAsync<IJSObjectReference>
                    ("import", "./confirm.js");
    }
    public async Task ShowModal(string id)
    {
        if (module is not null)
            await module.InvokeVoidAsync("showConfirm", id);
    }
    public async Task HideModal(string id)
    {
        if (module is not null)
            await module.InvokeVoidAsync("hideConfirm", id);
    }
    public async ValueTask DisposeAsync()
    {
        if (module is not null)
            await module.DisposeAsync();
    }
}
