using System.Collections.Generic;
using UnityEngine;

namespace Assets.Pool
{
    [CreateAssetMenu(fileName = "New Transform Pool", menuName = "Pool/Transform Pool", order = 51)]
    public class TransformRuntimePool : RuntimePool<Transform>
    {
        /// <param name="center">Center of circle</param>
        /// <param name="radius">Radius of circle</param>
        /// <returns>Closest Transform to center of circle</returns>
        public Transform GetNearestToCenterInCircle2D(Vector2 center, float radius)
        {
            var distanceToNearestTransform = Mathf.Infinity;
            Transform nearestTransform = null;
            foreach (var transform in enabledItems)
            {
                var distance = Vector2.Distance(center, transform.transform.position);
                if (!(distance < radius)) continue;
                if (!(distance < distanceToNearestTransform)) continue;
                distanceToNearestTransform = distance;
                nearestTransform = transform;
            }
            return nearestTransform;
        }

        /// <returns>Closest Transform to position</returns>
        public Transform GetNearestToPosition2D(Vector2 position)
        {
            return GetNearestToCenterInCircle2D(position, Mathf.Infinity);
        }

        public List<Transform> GetTransformListInCircle2D(Vector2 center, float radius)
        {
            var list = new List<Transform>(enabledItems.Count);
            foreach (var transform in enabledItems)
            {
                var distance = Vector2.Distance(transform.position, center);
                if (distance > radius)
                {
                    continue;
                }
                list.Add(transform);
            }
            return list;
        }
    }
}