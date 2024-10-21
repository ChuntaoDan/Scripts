using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    private int reverseInterval;
    private int rotationStep;

    // Start is called before the first frame update
    void Start()
    {
        reverseInterval = 5;
        rotationStep = -30;
    }

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationStep, 0) * Time.deltaTime);
        if ((int)Time.deltaTime % reverseInterval == 0 )
         {
            //rotationStep = -rotationStep;
         }
    }
}
