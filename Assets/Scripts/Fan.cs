using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public GameObject gameobject;
    public Task task;
    public GameObject button;
    public GameObject Onbutton;

    // Update is called once per frame
    

    public void ButtonPressed(){
        task.x = true;
        Onbutton.SetActive(true);
        button.SetActive(false);
    }
}
