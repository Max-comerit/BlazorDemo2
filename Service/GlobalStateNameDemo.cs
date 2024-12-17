public class GlobalStateNameDemo
{
    public string CurrentName { get; private set; } = "Anon";

    public event Action? OnChange;

    public void ChangeName(string newName)
    {
        if (!string.IsNullOrWhiteSpace(newName) && CurrentName != newName)
        {
            CurrentName = newName;
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged()
    {
        OnChange?.Invoke();
    }
}