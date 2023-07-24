using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Enemy_Scripts.Enemy_Manager
{
    public class EnemiesManager : MonoBehaviour
    {
        public static EnemiesManager instance;
        public List<Enemy> enemies;
        public UnityEvent onChanged;

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

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
            onChanged.Invoke();
        }
        
        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
            onChanged.Invoke();
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
