using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    #region Singleton
    private static ObserverManager _instance = null;
    public static ObserverManager Instance => _instance;
  
    void Awake()
    {
        _instance = this;
    }
    #endregion
    private List<Subject> _subjects;
    public void RegisterSubject(Subject _subject)
    {
        if (_subjects == null)
            _subjects = new List<Subject>();
        _subjects.Add(_subject);
    }
    public void RegisterObserver(Observer _observer,SubjectType _subjectType)
    {
        foreach (var _subject in _subjects)
        {
            if(_subject.SubjectType == _subjectType)
            {
                _subject.RegisterObserver(_observer);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
public enum NotificationType
{
    Forward,
    Back,
    Left,
    Right
}
public enum SubjectType
{
    Move
}
