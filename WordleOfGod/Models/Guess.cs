namespace WordleOfGod.Models;

public class Guess
{
	public string? Text { get; set; }
	public int? Score { get; set; }
	public Position? Position { get; set; }
	public event Action? Send;

	public void NotifySend() => Send?.Invoke();
}