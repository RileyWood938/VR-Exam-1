using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    /// <summary>
    /// simple function to switch levels. called by GazeOverEvent
    /// </summary>
    public void switchLevels()
    {
        SceneManager.LoadScene(1);
    }
}
