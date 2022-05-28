namespace WordleOfGod.Models;

public class Guess
{
    public DateTime Date { get; set; }
    public string? Text { get; set; }
	public int? Score { get; set; }
	public Position? Position { get; set; }
	public event Action? Send;

    public Guess()
    {
        Date = DateTime.Today;
    }

	public void NotifySend() => Send?.Invoke();
}