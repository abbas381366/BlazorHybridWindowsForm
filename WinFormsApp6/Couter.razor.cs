using Microsoft.AspNetCore.Components;

namespace WinFormsApp6;

public partial class Couter
{
    [Inject] public StateManager StateManager { get; set; }
    int counter = 0;
    protected override async Task OnInitializedAsync()
    {
        StateManager.OnStatechanged += async (o, e) =>
        {
            await InvokeAsync(StateHasChanged);
        };
    }
    async Task OnClick()
    {
        StateManager.Counter++;
    }
}