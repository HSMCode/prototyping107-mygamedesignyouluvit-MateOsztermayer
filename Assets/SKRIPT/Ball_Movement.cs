using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public bool isOnGround = true; 
    private Rigidbody2D _RB;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {  
        _RB = GetComponent<Rigidbody2D>();
        //Physics.gravity = Physics.gravity * gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnGround) 
         {
            _RB.AddForce(new Vector2 (0,70));
            isOnGround = false;
         }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         
         {
             isOnGround = true;
         }
    }

}
