using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnderScript : MonoBehaviour
{ /// <summary>
/// this script changes levels after 30 seconds. since the timer resets in new scenes, I opted for 2 30 second timers.
/// </summary>
    private float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
