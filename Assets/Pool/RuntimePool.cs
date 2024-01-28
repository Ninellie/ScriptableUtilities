using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Pool
{
    public abstract class RuntimePool<T> : ScriptableObject
    {
        public bool enableGettingEnabledItems;
        public List<T> disabledItems = new();
        public List<T> enabledItems = new();

        public T Get()
        {
            if (disabledItems.Count != 0)
            {
                return disabledItems.First();
            }

            if (!enableGettingEnabledItems)
            {
                return default;
            }

            if (enabledItems.Count != 0)
            { 
                return enabledItems.First();
            }

            return default;
        }

        public void Add(T item)
        {
            var add = !enabledItems.Contains(item);
            var remove = disabledItems.Contains(item);

            if (add)
            {
                enabledItems.Add(item);
            }

            if (remove)
            {
                disabledItems.Remove(item);
            }
        }

        public void Remove(T item)
        {
            var add = !disabledItems.Contains(item);
            var remove = enabledItems.Contains(item);

            if (add)
            {
                disabledItems.Add(item);
            }

            if (remove)
            {
                enabledItems.Remove(item);
            }
        }
    }
}