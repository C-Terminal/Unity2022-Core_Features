using System;
using Enemy_Scripts.Enemy_Manager;
using UnityEngine;

namespace Enemy_Scripts
{
    public class Enemy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            EnemiesManager.instance.enemies.Add(this);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnDestroy()
        {
            EnemiesManager.instance.enemies.Remove(this);
        }
    }
}
