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
}