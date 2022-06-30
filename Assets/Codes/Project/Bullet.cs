using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlantformShoot
{
    public class Bullet : MonoBehaviour
    {
        void Start()
        {
            Destroy(this.gameObject, 3f);
        }

        void Update()
        {
            transform.Translate(12 * Time.deltaTime, 0, 0);
        }
    }
}


