using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinScript : MonoBehaviour
{
    /// <summary>
    /// this activates on prefab spawn to spin them
    /// </summary>
    private Rigidbody rb;
    private float timer;

    void Start()
    {
        timer = 0; //start a tiumer to control how long they spin for
        rb = GetComponent<Rigidbody>(); //get their rigidbody component to add a torque to

    }
    void Update()
    { //check to see if the time is up before doing math to save processing power
        if (timer < .5){
            timer += Time.deltaTime;
            rb.AddRelativeTorque(Vector3.up * 2000000);
        }
        
    }
}
