using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlantformShoot
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _mRig2D;
        private float _mGroundMoveSpeed = 5f;
        private float _mJumpForce = 12f;

        private void Start()
        {
            _mRig2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                var bullet = Resources.Load<GameObject>("Bullet");

                GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                _mRig2D.velocity = new Vector2(_mRig2D.velocity.x, _mJumpForce);
            }
        }

        private void FixedUpdate()
        {
            _mRig2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 5, _mRig2D.velocity.y);
        }
    }
}

