using System.Collections.Generic;
using Assets.Variables;
using UnityEngine;

namespace Assets.StatSourceSystem
{
    [CreateAssetMenu(fileName = "New Stat Variable", menuName = "Variables/Stat", order = 51)]
    public class StatVariable : FloatVariable
    {
        [field: SerializeField] public StatId id { get; private set; }

        /// <summary>
        /// The list of listeners that this stat will notify if it is changed.
        /// </summary>
        private readonly List<StatListener> _onChangedEventListeners = new();

        public static implicit operator float(StatVariable reference)
        {
            return reference.value;
        }

        // Event methods
        public void Raise()
        {
            for (int i = _onChangedEventListeners.Count - 1; i >= 0; i--)
                _onChangedEventListeners[i].OnEventRaised(value);
        }

        public void RegisterListener(StatListener listener)
        {
            if (!_onChangedEventListeners.Contains(listener))
                _onChangedEventListeners.Add(listener);
        }

        public void UnregisterListener(StatListener listener)
        {
            if (_onChangedEventListeners.Contains(listener))
                _onChangedEventListeners.Remove(listener);
        }

        // Variable methods
        public new void SetValue(float value)
        {
            var oldValue = this.value;
            this.value = value;
            TryRaiseEvent(oldValue);
        }

        public void SetValue(FloatVariable value)
        {
            var oldValue = this.value;
            this.value = value.value;
            TryRaiseEvent(oldValue);
        }

        public void SetValue(StatVariable value)
        {
            var oldValue = this.value;
            this.value = value.value;
            TryRaiseEvent(oldValue);
        }

        public new void ApplyChange(float amount)
        {
            var oldValue = value;
            value += amount;
            TryRaiseEvent(oldValue);
        }

        public new void ApplyChange(FloatVariable amount)
        {
            var oldValue = value;
            value += amount.value;
            TryRaiseEvent(oldValue);
        }

        public void ApplyChange(StatVariable amount)
        {
            var oldValue = value;
            value += amount.value;
            TryRaiseEvent(oldValue);
        }

        private void TryRaiseEvent(float oldValue)
        {
            if (oldValue.Equals(value)) return;
            Raise();
        }
    }
}