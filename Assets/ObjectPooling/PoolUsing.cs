using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolUsing : MonoBehaviour
{
    [SerializeField] private float _spawmTime = 1;
    [SerializeField] private PoolMechanic _poolMechanic;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawmObject());
    }
    IEnumerator SpawmObject()
    {
        int _counter = 0;
        while (true)
        {
            GameObject _obj = _poolMechanic.GetGameObject(_counter++ % 2);
            _obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(_spawmTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
