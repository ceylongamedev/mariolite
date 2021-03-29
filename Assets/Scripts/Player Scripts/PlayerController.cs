using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarioLite
{
    public class PlayerController : MonoBehaviour
    {
        #region variables
        public float speed = 1.5f;
        public float jumpForce = 5.0f;

        private float _moveInput;
      
        private Rigidbody2D _rBody;
        #endregion

        private void Awake()
        {
            _rBody = GetComponent<Rigidbody2D>();
        }//Awake

        void Update()
        {
            
        }//Update

        private void FixedUpdate()
        {
            MovePlayer();
        }//FixedUpdate

        private void MovePlayer()
        {
            _moveInput = Input.GetAxisRaw("Horizontal");
            

            if(_moveInput > 0)
            {
                _rBody.velocity = new Vector2(speed, _rBody.velocity.y);
            }
            else if(_moveInput < 0)
            {
                _rBody.velocity = new Vector2(-speed, _rBody.velocity.y);
            }

            else if (_moveInput == 0)
            {
                _rBody.velocity = new Vector2(0, _rBody.velocity.y);
            }
            
        }//MovePlayer
    }//class
}


