using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanelObserver : Subject
{
    public void ForwardOnClick()
    {
        Notify(NotificationType.Forward);
    }
    public void BackOnClick()
    {
        Notify(NotificationType.Back);
    }
    public void RightOnClick()
    {
        Notify(NotificationType.Right);
    }
    public void LeftOnClick()
    {
        Notify(NotificationType.Left);
    }

}
