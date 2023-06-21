using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public class MovementController: MonoBehaviour

    {
        [SerializeField] private float _linearSpeed = 1;
        [SerializeField] private float _angularSpeed = 1;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private Rail _rail;

        private float _currentLinearSpeed;
        private float _currentAngularSpeed;

        private IMovable _regularMovable;

        private IMovable _currentMovable;

        private bool isMove = false;

        public MovementController(float linearSpeed, float angularSpeed, Rigidbody2D rigidbody2D, Rail rail)
        {
            _linearSpeed = linearSpeed;
            _angularSpeed = angularSpeed;
            _rigidbody2D = rigidbody2D;
            _rail = rail;
        }

        private void Awake()
        {
            _regularMovable = new RegularMovement(_rigidbody2D,_rail, transform);
            _currentMovable = _regularMovable;
        }

        private void FixedUpdate()
        {
            if (isMove)
            {
                _currentMovable.UpdateRailFollowerPosition(_linearSpeed);
                _currentMovable.DoRotate(_angularSpeed);
            }
            
        }
        public void OnSwitchDirection()
        {
            _currentMovable.DoMove(_linearSpeed);
            isMove = true;
        }
        //public void OnSet
        public void Reset()
        {
            _rail = GetRail().GetComponent<Rail>();
        }

        private GameObject GetRail()
        {
            GameObject railObject = GameObject.FindGameObjectWithTag("Rail");

            return railObject;
        }
    }
}