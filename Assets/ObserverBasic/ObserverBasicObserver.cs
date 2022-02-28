using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverBasicObserver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ObserverBasicSubject.OnButtonClicked += Move;
    }
    public void Move(Vector3 direction) => transform.Translate(direction);
}
