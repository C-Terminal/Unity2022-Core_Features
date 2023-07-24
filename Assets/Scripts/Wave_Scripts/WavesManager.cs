using System;
using System.Collections.Generic;
using UnityEngine;

namespace Wave_Scripts
{
    public class WavesManager : MonoBehaviour
    {

        public static WavesManager instance;

        public List<WaveSpawner> waves;

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
