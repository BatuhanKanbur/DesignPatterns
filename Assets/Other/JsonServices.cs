using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonServices : MonoBehaviour
{
    public string ConvertJson(object _obj)
    {
        return  JsonUtility.ToJson(_obj);
    }
    public T LoadJson<T>(string _jSon)
    {
        return (T)Convert.ChangeType(JsonUtility.FromJson<T>(_jSon), typeof(T));
       // return (T)Convert.ChangeTypeJsonUtility.FromJson<T>(_jSon);
    }
}
