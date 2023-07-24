using System.Collections;
using System.Collections.Generic;
using Enemy_Scripts.Enemy_Manager;
using UnityEngine;
using UnityEngine.SceneManagement;
using Wave_Scripts;


public class WavesGameMode : MonoBehaviour
{
    [SerializeField] private Life playerLife;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 &&
            WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("You Win!");
        }

        if (playerLife.amount <= 0)
        {
            SceneManager.LoadScene("You Lose! HA.");
        }
    }
}
