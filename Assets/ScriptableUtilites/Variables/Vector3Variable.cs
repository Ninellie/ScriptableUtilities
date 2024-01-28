using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New Vector3 Variable", menuName = "Variables/Vector3", order = 53)]
    public class Vector3Variable : Variable<Vector3>
    {
        public void ApplyChange(Vector3 amount)
        {
            value += amount;
        }

        public void ApplyChange(Vector3Variable amount)
        {
            value += amount.value;
        }
    }

    [Serializable]
    public class Vector3Reference
    {
        public bool useConstant;
        public Vector3 constantValue;
        public Vector3Variable variable;

        public Vector3 Value => useConstant ? constantValue : variable.value;

        public Vector3Reference()
        { }

        public Vector3Reference(Vector3 value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator Vector3(Vector3Reference reference)
        {
            return reference.Value;
        }

        public static implicit operator Vector2(Vector3Reference reference)
        {
            return reference.Value;
        }
    }
}