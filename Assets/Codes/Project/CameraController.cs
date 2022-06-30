using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlantformShoot
{
    public class CameraController : MonoBehaviour
    {
        private Transform _mTarget;

        private void Start()
        {
            _mTarget = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void LateUpdate()
        {
            transform.localPosition = new Vector3(_mTarget.position.x, _mTarget.position.y, -10);
        }
    }
}

