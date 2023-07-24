using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{

    public int amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        var life = GetComponent<Life>();
        
        //Call the AddListener function of the onDeath field of the Life reference and pass the
        // GivePoints function as the first argument. This is known as subscribing our listener
        // method GivePoints to the event onDeath. The idea is to tell Life to execute GivePoints
        // when the onDeath event is invoked. This way, Life informs us about that situation. 
        life.onDeath.AddListener(GivePoints);
    }

    private void GivePoints()
    {
        ScoreManager.instance.amount += amount;
    }
}
