using UnityEngine;
using UnityEngine.Events;

namespace Assets.Events
{
    [CreateAssetMenu(fileName = "New Int Event", menuName = "Events/Int", order = 51)]
    public class IntEventListener : MonoBehaviour
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

    [CreateAssetMenu(fileName = "New Void Event", menuName = "Events/Void", order = 51)]
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GameEvent gameEvent;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            response.Invoke();
        }
    }
}