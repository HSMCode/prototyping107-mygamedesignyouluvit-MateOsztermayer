using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject RB;
    private Transform target; 

    private Vector3 offset = new Vector3(0f,0f,-25f);

    // Start is called before the first frame update
    void Start()
    {
        target = RB.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // set camera to the position, converted to world space
        transform.position = target.TransformPoint(offset);

        transform.LookAt(target);
    }
}