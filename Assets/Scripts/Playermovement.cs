using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    Vector3 m_movement;
    public float Playerspeed = 0.05f;

    void Update()
    {
        float horizontal = Playerspeed*Input.GetAxis("Horizontal");
        float vertical = Playerspeed*Input.GetAxis ("Vertical");
        m_movement.Set(horizontal,vertical,0f);
        transform.position = transform.position + m_movement;
    }
}
