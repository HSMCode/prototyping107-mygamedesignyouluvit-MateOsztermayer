using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Level_Controller : MonoBehaviour
{
    
    public float speed = 25f; 
    private float verticalInput; // Input of arrow keys up and down
    private float horizontalInput; // Input of L and R arrow keys 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
    }
}
