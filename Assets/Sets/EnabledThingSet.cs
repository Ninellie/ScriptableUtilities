using UnityEngine;

namespace Assets.Sets
{
    [CreateAssetMenu(fileName = "New enabled Thing Set", menuName = "Sets/Enabled Thing Set", order = 51)]
    public class EnabledThingSet : RuntimeSet<EnabledThing> { }
}