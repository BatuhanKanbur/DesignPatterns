using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolMechanic : MonoBehaviour
{
    [Serializable]
    public struct PoolObject
    {
        public Queue<GameObject> poolObjects;
        public GameObject objectPrefab;
        public int poolLenght;
    }
    public PoolObject[] _pools; 
    void Awake()
    {
        for (int i = 0; i < _pools.Length; i++) 
        {
            _pools[i].poolObjects = new Queue<GameObject>(); 
            for (int y = 0; y < _pools[i].poolLenght; y++) 
            {
                GameObject _gO = Instantiate(_pools[i].objectPrefab); 
                _gO.transform.position = Vector3.zero;
                _gO.SetActive(false);
                _pools[i].poolObjects.Enqueue(_gO);
            }
        }
    }

    public GameObject GetGameObject(int _type)
    {
        GameObject _gO = _pools[_type].poolObjects.Dequeue();
        _gO.SetActive(true);
        _pools[_type].poolObjects.Enqueue(_gO);
        return _gO;
    }
}
