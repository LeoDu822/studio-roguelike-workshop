using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
     
        Debug.Log("MEOW!");
        
    }
    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 10;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
