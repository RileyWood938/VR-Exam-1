using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDuplicator2 : MonoBehaviour
{
    public GameObject prefab;

    public void duplicate()
    {
            GameObject a = Instantiate(prefab) as GameObject;
            a.transform.position = gameObject.transform.position + new Vector3(0, 1, 0);
            a.transform.rotation = new Quaternion(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));

    }
}
