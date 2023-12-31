using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Player;
    public GameObject button;
    public GameObject Label;
    public Task[] TaskedObjects;
    bool check = true;
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject == Player){
            foreach(Task TaskedObject in TaskedObjects){
                if(TaskedObject.x == false){
                    check = false;
                }
            }
            if(check){
                button.SetActive(true);
            }
            else{
                Label.SetActive(true);
            }
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject == Player){
            Label.SetActive(false);
            check = true;
            button.SetActive(false);
        }
    }
    
}
