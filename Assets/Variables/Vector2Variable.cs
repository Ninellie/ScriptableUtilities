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
}