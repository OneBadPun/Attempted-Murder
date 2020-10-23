using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            target = player.transform.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            MoveCamera();
        }

    }
    // Move camera based off player position
    private void MoveCamera()
    {
        
    }
}
