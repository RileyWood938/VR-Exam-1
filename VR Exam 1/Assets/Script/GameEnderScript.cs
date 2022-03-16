using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnderScript : MonoBehaviour
{
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
