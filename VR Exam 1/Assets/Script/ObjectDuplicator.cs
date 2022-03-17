using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ObjectDuplicator : MonoBehaviour
{
    /// <summary>
    /// this script duplicates objects. It keeps track of how many duplicates there are and sends an event once it has too many.
    /// </summary>
    
    public GameObject prefab; // this prefab is what will be spawned
    private int ObjectCount = 1; //object count starts at one rather than zero for readability (max objects = 3 rather than 2)
    public UnityEvent MaxObjects; //declare the event triggered when there are too many objects

    public void duplicate()
    {
        if (ObjectCount < 3) //only spawn a duplicate if there are not too many objects already
        {
            GameObject a = Instantiate(prefab) as GameObject; 
            a.transform.position = gameObject.transform.position + new Vector3(0, ObjectCount, 0); //set the position to be above the initial object. position gets higher with every spawn
            a.transform.rotation = new Quaternion(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180)); //randomiz spawn rotation
            ObjectCount += 1;

            if(ObjectCount == 3)
            {
                MaxObjects.Invoke();
            }
        }
        
    }
}
