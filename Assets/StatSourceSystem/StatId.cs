using UnityEngine;

namespace Assets.StatSourceSystem
{
    [CreateAssetMenu(fileName = "New Stat Id", menuName = "Source stat system/Stat Id", order = 51)]
    public class StatId : ScriptableObject
    {
        [field: SerializeField] public string Value { get; private set; } = string.Empty;
        [SerializeField] private string _description;
    }
}