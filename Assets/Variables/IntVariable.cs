using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New Int Variable", menuName = "Variables/Int", order = 52)]
    public class IntVariable : Variable<int>
    {
        public void ApplyChange(int amount)
        {
            value += amount;
        }

        public void ApplyChange(IntVariable amount)
        {
            value += amount.value;
        }
    }

    [Serializable]
    public class IntReference
    {
        public bool useConstant;
        public int constantValue;
        public IntVariable variable;

        public int Value => useConstant ? constantValue : variable.value;

        public IntReference()
        { }

        public IntReference(int value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator float(IntReference reference)
        {
            return reference.Value;
        }

        public static implicit operator int(IntReference reference)
        {
            return reference.Value;
        }
    }
}