namespace Chapter18JsInterop;

public interface IModalService
{
    Task HideModal(string id);
    Task Init();
    Task ShowModal(string id);
}
