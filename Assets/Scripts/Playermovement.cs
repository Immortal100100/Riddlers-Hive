using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    Vector3 m_movement;
    public float Playerspeed = 0.05f;
    public Animator animator;
    public SpriteRenderer sr;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        m_movement.Set(horizontal,vertical,0f);
        m_movement.Normalize();
        m_movement.x*= Playerspeed;
        m_movement.y*= Playerspeed;
        transform.position = transform.position + m_movement;
        if(horizontal!=0f || vertical!=0f){
            animator.SetBool("Walking",true);
        }
        else{
            animator.SetBool("Walking",false);
        }
        if(horizontal>0f){
            sr.flipX=true;
        }
        else{
            sr.flipX=false;
        }

    }
}
