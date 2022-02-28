using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Move(string _moveDir)
    {
        print(_moveDir);
        switch (_moveDir)
        {
            case "F":
                transform.Translate(Vector3.forward);
                break;
            case "B":
                transform.Translate(Vector3.back);
                break;
            case "R":
                transform.Translate(Vector3.right);
                break;
            case "L":
                transform.Translate(Vector3.left);
                break;
        }
    }
}
