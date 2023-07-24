using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Wave_Scripts
{
    public class WavesManager : MonoBehaviour
    {

        public static WavesManager instance;

        public List<WaveSpawner> waves;
        public UnityEvent onChanged;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Debug.LogError("Duplicated WaveManager", gameObject);
            }
        }

        public void AddWave(WaveSpawner wave)
        {
            waves.Add(wave);
            onChanged.Invoke();
        }
        
        public void RemoveWave(WaveSpawner wave)
        {
            waves.Remove(wave);
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
