using UnityEngine;

namespace Assets.Sets
{
    public class EnabledThing : MonoBehaviour
    {
        public EnabledThingSet set;

        private void OnEnable()
        {
            set.Add(this);
        }

        private void OnDisable()
        {
            set.Remove(this);
        }
    }
}