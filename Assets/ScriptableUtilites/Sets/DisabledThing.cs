using UnityEngine;

namespace Assets.Sets
{
    public class DisabledThing : MonoBehaviour
    {
        public DisabledThingSet set;

        private void OnEnable()
        {
            set.Remove(this);
        }

        private void OnDisable()
        {
            set.Add(this);
        }
    }
}