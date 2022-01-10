using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float velocity = 1; //velocidad del personaje
    private Rigidbody2D rb; // la física del personaje
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Se extrae la física del componente (personaje)
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity; //se toma la variable con la física del personaje
            
            Debug.Log(Vector2.up);
            Debug.Log(rb.velocity);
            Debug.Log(velocity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        
    }
}
