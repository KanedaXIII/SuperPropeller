using UnityEngine;
using UnityEngine.Serialization;

namespace Code
{
    [RequireComponent(typeof(MovementController))]
    [RequireComponent(typeof(ColourController))]
    // [RequireComponent(typeof(HealthController))]
    public class Propeller : MonoBehaviour
    {
        [SerializeField] private MovementController _movementController;
        [SerializeField] private ColourController _colourController;
        [SerializeField] private HealthController _healthController;

        private void Awake()
        {
            Reset();
        }

        public void Reset()
        {
            _movementController.Reset();
            _colourController.Reset();
            _healthController.Reset();

        }
    }
}
