using UnityEngine.Events;
using UnityEngine;

namespace Assets.Events
{
    [CreateAssetMenu(fileName = "New UInt Event", menuName = "Events/UInt", order = 51)]
    public class UIntEvent : BaseGameEvent<uint> { }

    public class UIntEventListener : MonoBehaviour, IGameEventListener<uint>
    {
        [Tooltip("Event to register with.")]
        public UIntEvent gameEvent;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<uint> response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(uint value)
        {
            response.Invoke(value);
        }
    }
}