using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanon : MonoBehaviour
{
    public GameObject gameobject;
    public Task task;
    public GameObject button;
    public GameObject Offbutton;
    public ShowButton showingbutton;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("p")){
            ButtonPressed();
        }
        if(!showingbutton.collided){
            button.SetActive(false);
        }
    }

    public void ButtonPressed(){
        task.x = false;
        Offbutton.SetActive(true);
        button.SetActive(false);
    }
}
