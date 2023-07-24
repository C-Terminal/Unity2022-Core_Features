using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        //Get Component attempts to get a component from the object by name, if not exist returns null
        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.amount -= damage;
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}