using System;
using UnityEngine;

namespace Assets.Variables
{
    [CreateAssetMenu(fileName = "New GameObject Variable", menuName = "Variables/GameObject", order = 54)]
    public class GameObjectVariable : Variable<GameObject>
    {
    }

    [Serializable]
    public class GameObjectReference
    {
        public bool useConstant;
        public GameObject constantValue;
        public GameObjectVariable variable;

        public GameObject Value => useConstant ? constantValue : variable.value;

        public GameObjectReference()
        { }

        public GameObjectReference(GameObject value)
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator GameObject(GameObjectReference reference)
        {
            return reference.Value;
        }
    }
}