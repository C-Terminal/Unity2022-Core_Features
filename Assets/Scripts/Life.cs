using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    public float amount;
    public UnityEvent onDeath;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (amount <= 0)
        {
            // When life reaches 0, call the Invoke function of the event. This way, we will be telling any
            // script interested in the event that it has happened:
            onDeath.Invoke();
            Destroy(gameObject);
        }
    }
}