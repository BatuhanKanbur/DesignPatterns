using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueprintSaveLoad : JsonServices
{
    [Serializable]
    public class BlueprintObject
    {
        public string objectName;
        public Vector3 objectPos;
        public Vector3 objectRot;
        public string transformParent;
    }
    [Serializable]
    public class BlueprintObjectsList
    {
        public List<BlueprintObject> blueprintObjects;
    }
    public BlueprintObjectsList blueprintList;
    public BlueprintObjectsList blueprintList1;
    void Start()
    {
        MeshRenderer[] _gos = FindObjectsOfType<MeshRenderer>();
        foreach (var _go in _gos)
        {
            BlueprintObject _newObj = new BlueprintObject();
            _newObj.objectName = _go.name;
            _newObj.objectPos = _go.transform.position;
            _newObj.objectRot = _go.transform.localEulerAngles;
            _newObj.transformParent = GetGameObjectPath(_go.transform);
            blueprintList.blueprintObjects.Add(_newObj);
        }
        string _jsonStr = ConvertJson(blueprintList);
        print("Kaydedildi : " +_jsonStr);
        blueprintList1 = LoadJson<BlueprintObjectsList>(_jsonStr);
        print("Yüklendi");
      //  blueprintList.blueprintObjects.Clear();
    }
    //public void LoadJson(string _str)
    //{
    //    blueprintList1 = JsonUtility.FromJson<BlueprintObjectsList>(_str);
    //}
    public Vector3 GetJsonVector3(string _vector3Str)
    {
        return Vector3.zero;
    }
    public float ConvertFloat(string _floatStr)
    {
        return float.Parse(_floatStr);
    }
    private string GetGameObjectPath(Transform transform)
    {
        string path = "";
        while (transform.parent != null)
        {
            transform = transform.parent;
            path = transform.name + "/" + path;
        }
        return path;
    }

}
