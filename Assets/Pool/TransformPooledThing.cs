using UnityEngine;

namespace Assets.Pool
{
    public class TransformPooledThing : MonoBehaviour
    {
        public Transform Transform { get; private set; }

        public TransformRuntimePool runtimePool;

        private void OnEnable()
        {
            if (Transform == null) Transform = transform;
            runtimePool.Add(Transform);
        }

        private void OnDisable()
        {
            if (Transform == null) Transform = transform;
            runtimePool.Remove(Transform);
        }
    }
}