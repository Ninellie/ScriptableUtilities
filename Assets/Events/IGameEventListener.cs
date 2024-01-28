namespace Assets.Events
{
    public interface IGameEventListener<in T>
    {
        void OnEventRaised(T value);
    }
}