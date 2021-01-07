using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
 public GameObject WinScreenUi;
   public void Reset()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       Time.timeScale = 1f;
    }

   public void NextLevl()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
