using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlattformBehavior : MonoBehaviour
{
    private SpriteRenderer rend;
    private BoxCollider2D col;
    private int bounceCount;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        col = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (bounceCount <= 0)
        {
            Color c = rend.material.color;
            c = Color.white;
            rend.material.color = c;
        }
        else if (bounceCount == 1)
        {
            Color c = rend.material.color;
            c = Color.green;
            rend.material.color = c;
        }
        else if (bounceCount == 2)
        {
            Color c = rend.material.color;
            c = Color.yellow;
            rend.material.color = c;
        }
        else if (bounceCount == 3)
        {
            Color c = rend.material.color;
            c = Color.red;
            rend.material.color = c;
        }
        else if (bounceCount >= 4)
        {
            bounceCount = 0;
            StartCoroutine(PlattformRespawnCo());
        }
    }

    IEnumerator PlattformRespawnCo()
    {
        rend.enabled = false;
        col.enabled = false;

        yield return new WaitForSeconds(3f);

        rend.enabled = true;
        col.enabled = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bounceCount++;
        }
    }
}
