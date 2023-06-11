using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Transform transform;
    Vector3 m_movement;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        m_movement.Set(0.1f*horizontal,0.1f*vertical,0f);
        transform.position = transform.position + m_movement;
    }
}
