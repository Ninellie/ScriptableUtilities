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
}