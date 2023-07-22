using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    public Task task;
    public GameObject button;
    public Task Lighter;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("l")){
            ButtonPressed();
        }
    }

    public void ButtonPressed(){
        if(Lighter.x == true){
        task.x = true;
        animator.SetBool("Lit",true);
        button.SetActive(false);
        }
    }
}
