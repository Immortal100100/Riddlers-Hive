using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorbutton : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("space") || Input.GetKey("enter")){
        doorUnlocked();
       } 
    }

    public void doorUnlocked(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
