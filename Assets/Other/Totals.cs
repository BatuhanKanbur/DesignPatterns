using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Totals : MonoBehaviour
{
    string _url = "http://blablabla.com/Api.php?action=";
    [System.Serializable]
    public class DatabaseData
    {
        public string Name;
    }
    [System.Serializable]
    public class DatabaseList
    {
        public DatabaseData[] DatabaseAllList;
    }
    public DatabaseList DatabaseElements;


    public float GetNavmeshSpeed(NavMeshAgent _navMeshAgent)
    {
        float _navMeshVelocity = _navMeshAgent.velocity.magnitude / _navMeshAgent.speed;
        return _navMeshVelocity;
    }
    public List<T> ShuffleList<T>(List<T> _list)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            T temp = _list[i];
            int randomIndex = Random.Range(i, _list.Count);
            _list[i] = _list[randomIndex];
            _list[randomIndex] = temp;
        }
        return _list;
    }
    public float Remap(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        var fromAbs = from - fromMin;
        var fromMaxAbs = fromMax - fromMin;

        var normal = fromAbs / fromMaxAbs;

        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;

        var to = toAbs + toMin;

        return to;
    }
    public float GetCurrentAnimatorTime(Animator _anim)
    {
        AnimatorStateInfo animState = _anim.GetCurrentAnimatorStateInfo(0);
        float currentTime = animState.normalizedTime % 1;
        return currentTime;
    }
    public string GetCurrentAnimatorName(Animator _anim)
    {
        AnimatorClipInfo[] animState = _anim.GetCurrentAnimatorClipInfo(0);
        string currentName = animState[0].clip.name;
        return currentName;
    }
    public GameObject FindClosetObject(string _goTag)
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(_goTag);
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
    IEnumerator CreateDatabaseForm()
    {
        WWWForm _dataForm = new WWWForm();
        _dataForm.AddField("name","Name");
        WWW _request = new WWW(_url + "CreateForm", _dataForm);
        yield return _request;
        if (!string.IsNullOrEmpty(_request.error))
        {
            print(_request.error);
        }
        else
        {
            print("SUCCES : " + _request.text);
        }
    }
    IEnumerator GetDatabaseToJson()
    {
        WWW _request = new WWW(_url + "ListAllDatabase");
        yield return _request;
        if (!string.IsNullOrEmpty(_request.error))
        {
            print(_request.error);
        }
        else
        {
            string _recJsonString = "{\"DatabaseAllList\":" + _request.text + "}";
            DatabaseElements = JsonUtility.FromJson<DatabaseList>(_recJsonString);
            print(_recJsonString);
        }

    }
}
