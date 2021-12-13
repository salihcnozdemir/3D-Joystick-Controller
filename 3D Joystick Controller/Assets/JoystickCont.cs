using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickCont : MonoBehaviour
{

    public Joystick joystick;
    public float joyHorizontal, JoyVertical = 0;

    void Start()
    {
    }
   
    void Update()
    {
        joyHorizontal = joystick.Horizontal;
        JoyVertical = joystick.Vertical;

        if (joyHorizontal != 0f || JoyVertical != 0f)
        {

            Vector3 direction = new Vector3(joyHorizontal, 0, JoyVertical).normalized;
            transform.Translate(direction * 0.005f, Space.World);

        }

    }

}