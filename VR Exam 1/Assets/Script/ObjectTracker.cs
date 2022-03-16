using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    private int finishedObjects = 0;
    public GameObject canvas;
    public void objectCount()
    {
        finishedObjects += 1;
        Debug.Log(finishedObjects);
        if (finishedObjects == 2)
        {
            canvas.SetActive(true);
        }
    }
}
