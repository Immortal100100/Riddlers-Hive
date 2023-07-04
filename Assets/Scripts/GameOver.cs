using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float displaytime = 2;

    // Update is called once per frame
    void Update()
    {
        if(displaytime>0){
            displaytime-= Time.deltaTime;
        }
        else{
            SceneManager.LoadScene(0);
        }
    }
}
