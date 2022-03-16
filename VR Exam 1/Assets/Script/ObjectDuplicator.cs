using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ObjectDuplicator : MonoBehaviour
{
    public GameObject prefab;
    private int ObjectCount = 1;
    public UnityEvent MaxObjects;

    public void duplicate()
    {
        if (ObjectCount < 3)
        {
            GameObject a = Instantiate(prefab) as GameObject;
            a.transform.position = gameObject.transform.position + new Vector3(0, ObjectCount, 0);
            a.transform.rotation = new Quaternion(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
            ObjectCount += 1;

            if(ObjectCount == 3)
            {
                MaxObjects.Invoke();
            }
        }
        
    }
}
