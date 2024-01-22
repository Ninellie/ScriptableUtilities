using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New Transform Variable", menuName = "Variables/Transform", order = 55)]
    public class TransformVariable : Variable<Transform> { }

    [Serializable]
    public class TransformReference
    {
        public bool useConstant;
        public Transform constantValue;
        public TransformVariable variable;

        public Transform Value => useConstant ? constantValue : variable.value;

        public TransformReference()
        { }

        public TransformReference(Transform value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator Transform(TransformReference reference)
        {
            return reference.Value;
        }
    }
}