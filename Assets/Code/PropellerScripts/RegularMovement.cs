using UnityEngine;

namespace Code
{
    public class RegularMovement: IMovable
    {
        private readonly Rigidbody2D _rigidbody2D;
        private readonly Rail _rail;
        private readonly Transform _transform;
        
        
        private void Start()
        {
            _rigidbody2D.MoveRotation(_rigidbody2D.rotation +100 * Time.deltaTime);
        }
        public RegularMovement(Rigidbody2D rigidbody2D,Rail rail, Transform transform)
        {
            _rigidbody2D = rigidbody2D;
            _rail = rail;
            _transform = transform;
        }

        public void DoMove(float linearSpeed)
        {
            if (_rigidbody2D.velocity.x > 0)
            {
                _rigidbody2D.velocity = new Vector2(-1.0f, 0.0f)*100;
            }
            else
            {
                _rigidbody2D.velocity = new Vector2(1.0f, 0.0f)*100;
            }
        }
        
        public void UpdateRailFollowerPosition(float linearSpeed)
        {
            Vector2 direction = _rigidbody2D.velocity.normalized;
            _rail.GetClosestPosition(direction);
            Vector2 railPosition = _rail.GetClosestPosition(direction);
            Vector2 targetPosition = railPosition;
            var position = _rigidbody2D.position;
            Vector2 moveDirection = (targetPosition - position).normalized;
            Vector2 newPosition = position + moveDirection * (linearSpeed * Time.fixedDeltaTime);
            _rigidbody2D.MovePosition(newPosition);
        }

        public void DoRotate(float angularSpeed)
        {
            if (_rigidbody2D.velocity.magnitude>0)
            {
                if (_rigidbody2D.velocity.x > 0)
                {
                    _rigidbody2D.angularVelocity = angularSpeed * -1;
                }
                else
                {
                    _rigidbody2D.angularVelocity = angularSpeed;
                }
            }
        }
    }
}