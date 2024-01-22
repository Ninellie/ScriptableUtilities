using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New Vector2 Variable", menuName = "Variables/Vector2", order = 53)]
    public class Vector2Variable : Variable<Vector2>
    {
        public void ApplyChange(Vector2 amount)
        {
            value += amount;
        }

        public void ApplyChange(Vector2Variable amount)
        {
            value += amount.value;
        }
    }


    [Serializable]
    public class Vector2Reference
    {
        public bool useConstant;
        public Vector2 constantValue;
        public Vector2Variable variable;

        public Vector2 Value => useConstant ? constantValue : variable.value;

        public Vector2Reference()
        { }

        public Vector2Reference(Vector2 value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator Vector2(Vector2Reference reference)
        {
            return reference.Value;
        }

        public static implicit operator Vector3(Vector2Reference reference)
        {
            return reference.Value;
        }
    }
}