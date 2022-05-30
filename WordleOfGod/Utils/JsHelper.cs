using Microsoft.JSInterop;
namespace WordleOfGod.Utils;

public static class JsHelper
{
	public static async Task CopyToClipboard(this IJSRuntime jsRuntime, string text)
		=> await jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);

	public static async Task OpenReading(this IJSRuntime jsRuntime)
		=> await jsRuntime.InvokeVoidAsync("openReading");

	public static async Task OpenMenu(this IJSRuntime jsRuntime)
		=> await jsRuntime.InvokeVoidAsync("openMenu");
}