using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public ParticleSystem dust;
    public bool isOnGround = true; 
    private Rigidbody2D _RB;
    public float gravityModifier;
    public GameObject characterHolder;

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
            CreateDust();
            StartCoroutine(JumpSqueeze(1.5f, 0.7f, 0.07f));
        }

        IEnumerator JumpSqueeze(float xSqueeze, float ySqueeze, float seconds)
        {
            Vector3 originalSize = Vector3.one;
            Vector3 newSize = new Vector3(xSqueeze, ySqueeze, originalSize.z);
            float t = 0f;
            while (t <= 1.0)
            {
                t += Time.deltaTime / seconds;
                characterHolder.transform.localScale = Vector3.Lerp(originalSize, newSize, t);
                yield return null;
            }
            t = 0f;
            while (t <= 1.0)
            {
                t += Time.deltaTime / seconds;
                characterHolder.transform.localScale = Vector3.Lerp(newSize, originalSize, t);
                yield return null;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {    
        {
            isOnGround = true;
        }
    }

    void CreateDust()
    {
        dust.Play();
    }
}
