using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIntoToilet : MonoBehaviour
{
    public GameObject Toilet;
    //get  a reference to the toilet prefab that will be spawned on click

    /// <summary>
    /// this gets called when the box is clicked on. It hides the box and instantiates the toilet where it used to be.
    /// the script is attached to the box mesh so gameopbject references the box mesh rather than the containing object
    /// this allows for the gaze over trigger to still be on even after the game object is set to off
    /// I initialy tried just disabling the mesh renderer component but I couldn't figure it out (although im sure a quick google search would tell me how)
    /// </summary>
    public void BecomeFlushableObject()
    {
        gameObject.SetActive(false);
        GameObject a = Instantiate(Toilet) as GameObject;
        a.transform.position = gameObject.transform.position;
    }
}
