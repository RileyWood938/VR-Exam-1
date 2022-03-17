using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    /// <summary>
    /// this script keeps track of how many objects have triggered the "maxobjects" event (when they have 2 duplicates) 
    /// and displays the "too many objects" canvas when both the box and toilet have reached 2 duplicates
    /// </summary>

    private int finishedObjects = 0;
    public GameObject canvas;
    public void objectCount()
    {
        finishedObjects += 1;
        if (finishedObjects == 2)
        {
            canvas.SetActive(true);
        }
    }
}
