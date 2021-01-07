using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private bool WinScreen = true;
    public GameObject WinScreenUI;
    private AudioSource audioSource;
    public AudioClip winSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        WinScreen = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Debug.Log("YOU WIN");
            WinScreen = true;  
            audioSource.PlayOneShot(winSound);

            if(WinScreen == true)
            {
                WinScreenUI.SetActive(true);
                WinScreen = false;
                Time.timeScale = 0f;
            }
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}