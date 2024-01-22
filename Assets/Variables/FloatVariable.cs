using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New Float Variable", menuName = "Variables/Float", order = 51)]
    public class FloatVariable : Variable<float>
    {
        public void ApplyChange(float amount)
        {
            value += amount;
        }

        public void ApplyChange(FloatVariable amount)
        {
            value += amount.value;
        }
    }

    [Serializable]
    public class FloatReference
    {
        public bool useConstant;
        public float constantValue;
        public FloatVariable variable;

        public float Value => useConstant ? constantValue : variable.value;

        public FloatReference()
        { }

        public FloatReference(float value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }

        public static implicit operator int(FloatReference reference)
        {
            return (int)reference.Value;
        }
    }
}