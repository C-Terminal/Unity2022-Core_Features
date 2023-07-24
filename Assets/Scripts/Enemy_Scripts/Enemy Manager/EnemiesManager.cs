using System;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy_Scripts.Enemy_Manager
{
    public class EnemiesManager : MonoBehaviour
    {
        public static EnemiesManager instance;
        public List<Enemy> enemies;

        private void Awake()
        {
            if (instance== null)
            {
                instance = this;
            }
            else
            {
                Debug.LogError("Multiple instances", gameObject);
            }
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
