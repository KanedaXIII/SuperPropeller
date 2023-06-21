using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public class Rail : MonoBehaviour
    {
        public List<Vector2> positions = new List<Vector2>();
        public Vector2 startRail;
        public Vector2 endRail;

        [SerializeField]
        private GameObject RailEndTrigger;

        private void Awake()
        {
            startRail = positions[0];
            endRail = positions[1];
        }

        private void Start()
        {
            GameObject.Instantiate(RailEndTrigger, startRail, Quaternion.identity);
            GameObject.Instantiate(RailEndTrigger, endRail, Quaternion.identity);
        }

        private void OnDrawGizmos() {
            Gizmos.color = Color.green;
            for (int i = 0; i < positions.Count - 1; i++) {
                Gizmos.DrawLine(positions[i], positions[i + 1]);
            }
        }
        
        public Vector2 GetClosestPosition(Vector2 point) {
            Vector2 closestPosition = positions[0];
            float closestDistance = Vector2.Distance(point, closestPosition);

            for (int i = 1; i < positions.Count; i++) {
                float distance = Vector2.Distance(point, positions[i]);
                if (distance < closestDistance) {
                    closestPosition = positions[i];
                    closestDistance = distance;
                }
            }

            return closestPosition;
        }
    }
}
