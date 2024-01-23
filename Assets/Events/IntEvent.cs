using UnityEngine.Events;
using UnityEngine;

namespace Assets.Events
{
    [CreateAssetMenu(fileName = "New Int Event", menuName = "Events/Int", order = 51)]
    public class IntEvent : BaseGameEvent<int> { }

    public class IntEventListener : MonoBehaviour, IGameEventListener<int>
    {
        [Tooltip("Event to register with.")]
        public IntEvent gameEvent;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<int> response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(int value)
        {
            response.Invoke(value);
        }
    }
}