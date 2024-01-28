using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New UInt Variable", menuName = "Variables/UInt", order = 52)]
    public class UIntVariable : Variable<uint>
    {
        public void ApplyChange(uint amount)
        {
            value += amount;
        }

        public void ApplyChange(UIntVariable amount)
        {
            value += amount.value;
        }
    }

    [Serializable]
    public class UIntReference
    {
        public bool useConstant;
        public uint constantValue;
        public UIntVariable variable;

        public uint Value => useConstant ? constantValue : variable.value;

        public UIntReference()
        { }

        public UIntReference(uint value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator float(UIntReference reference)
        {
            return reference.Value;
        }

        public static implicit operator int(UIntReference reference)
        {
            return (int)reference.Value;
        }

        public static implicit operator uint(UIntReference reference)
        {
            return reference.Value;
        }
    }
}