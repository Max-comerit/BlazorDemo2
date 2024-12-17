namespace BlazorDemo2.Service
{
    public class GlobalStateDemo
    {
        public int Counter { get; private set; } = 0;

        public event Action? OnChange;

        public void Increment(int value)
        {
            Counter += value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
