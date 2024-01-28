using UnityEngine.Events;
using UnityEngine;

namespace Assets.Events
{
    [CreateAssetMenu(fileName = "New Float Event", menuName = "Events/Float", order = 51)]
    public class FloatEvent : BaseGameEvent<float> { }

    public class FloatEventListener : MonoBehaviour, IGameEventListener<float>
    {
        [Tooltip("Event to register with.")]
        public FloatEvent gameEvent;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<float> response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(float value)
        {
            response.Invoke(value);
        }
    }
}