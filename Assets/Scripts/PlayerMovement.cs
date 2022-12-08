using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public float turnSpeed;
    
    
    float horizontal;
    float vertical;
  
    void Start()
    {
        
    }

    void Update()
    {
       InputPlayer();
       Movement();
        Rotate();
    }

    void InputPlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    //m�todo que controla el movimiento del personaje
    void Movement()
    {
        transform.Translate(Vector3.forward * speed * vertical * Time.deltaTime);
    }

    //m�todo que controla la rotaci�n del personaje
    void Rotate()
    {
        transform.Rotate(Vector3.up * turnSpeed * horizontal * Time.deltaTime);
    }
}
