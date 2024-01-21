using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New GameObject Variable", menuName = "Variables/GameObject", order = 54)]
    public class GameObjectVariable : Variable<GameObject>
    {
    }
}