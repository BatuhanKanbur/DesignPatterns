using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObserver : Observer
{
    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.Move);
    }
    public override void OnNotify(NotificationType _notificationType)
    {
        switch (_notificationType)
        {
            case NotificationType.Forward:
                transform.Translate(Vector3.forward);
                break;
            case NotificationType.Back:
                transform.Translate(Vector3.back);
                break;
            case NotificationType.Left:
                transform.Translate(Vector3.left);
                break;
            case NotificationType.Right:
                transform.Translate(Vector3.right);
                break;
        }
    }
}
