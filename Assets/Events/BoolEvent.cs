using UnityEngine.Events;
using UnityEngine;

namespace Assets.Events
{
    [CreateAssetMenu(fileName = "New Float Event", menuName = "Events/Float", order = 51)]
    public class BoolEvent : BaseGameEvent<bool> { }

    public class BoolEventListener : MonoBehaviour, IGameEventListener<bool>
    {
        [Tooltip("Event to register with.")]
        public BoolEvent gameEvent;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<bool> response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(bool value)
        {
            response.Invoke(value);
        }
    }
}