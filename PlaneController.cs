using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    private int reverseInterval;
    private int rotationStep;
    private float elapsedTime;
    private bool canReverse;

    // Start is called before the first frame update
    void Start()
    {
        reverseInterval = 5;
        rotationStep = -30;
        canReverse = true;
    }

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationStep, 0) * Time.deltaTime);
        elapsedTime += Time.deltaTime; // Accumulate elapsed time
        //if ((int)Time.deltaTime % reverseInterval == 0 )
        if ((int)elapsedTime % reverseInterval == 0 && canReverse)
         {
            rotationStep = -rotationStep;
            canReverse = false;
         }
    }
}
