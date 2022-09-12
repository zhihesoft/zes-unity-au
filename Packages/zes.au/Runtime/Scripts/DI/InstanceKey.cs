namespace Au.DI
{
    public interface InstanceKey
    {
        string key { get; }
        InstanceType type { get; }
    }
}