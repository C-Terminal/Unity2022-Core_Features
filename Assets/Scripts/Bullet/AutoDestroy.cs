using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    public class AutoDestroy : MonoBehaviour
    {
        public float delay;
        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, delay);
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}