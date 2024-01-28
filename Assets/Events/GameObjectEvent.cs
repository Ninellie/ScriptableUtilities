using UnityEngine.Events;
using UnityEngine;

namespace Assets.Events
{
    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Events/GameObject", order = 51)]
    public class GameObjectEvent : BaseGameEvent<GameObject> { }

    public class GameObjectEventListener : MonoBehaviour, IGameEventListener<GameObject>
    {
        [Tooltip("Event to register with.")]
        public GameObjectEvent gameEvent;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent<GameObject> response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(GameObject value)
        {
            response.Invoke(value);
        }
    }
}