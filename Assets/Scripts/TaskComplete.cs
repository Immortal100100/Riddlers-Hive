using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskComplete : MonoBehaviour
{
    public Task task;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("g")){
            ButtonPressed();
        }
    }

    public void ButtonPressed(){
        task.x = true;
    }
}
