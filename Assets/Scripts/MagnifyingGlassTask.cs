using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlassTask : MonoBehaviour
{
    public GameObject gameobject;
    public Task task;
    public GameObject button;
    Quaternion Rotate0 = Quaternion.Euler(0,0,90);
    Quaternion Rotate1 = Quaternion.Euler(0,0,0);

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("r")){
            ButtonPressed();
        }
    }

    public void ButtonPressed(){
        if(gameobject.transform.rotation==Rotate0){
            task.x = true;
        gameobject.transform.rotation = Rotate1;
        }
        else if(gameobject.transform.rotation == Rotate1){
        task.x = false;
        gameobject.transform.rotation = Rotate0;
        }
    }
}
