using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseControllerEvent : MonoBehaviour
{
    [Serializable]
    public class OnControllerMove : UnityEvent
    {
    }
    public OnControllerMove swipeRight;
    public OnControllerMove swipeLeft;
    public OnControllerMove swipeUp;
    public OnControllerMove swipeDown;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            swipeUp.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            swipeDown.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            swipeLeft.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            swipeRight.Invoke();
        }
    }
}
