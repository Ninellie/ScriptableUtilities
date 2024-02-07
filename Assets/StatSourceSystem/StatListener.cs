using Assets.Events;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.StatSourceSystem
{
    public class StatListener : MonoBehaviour, IGameEventListener<float>
    {
        [Tooltip("Stat to register with")]
        public StatVariable stat;

        [Tooltip("Response to invoke when stat value changes")]
        public UnityEvent<float> onChange;

        private void OnEnable()
        {
            stat.RegisterListener(this);
        }

        private void OnDisable()
        {
            stat.UnregisterListener(this);
        }

        public void OnEventRaised(float value)
        {
            onChange.Invoke(value);
        }
    }
}