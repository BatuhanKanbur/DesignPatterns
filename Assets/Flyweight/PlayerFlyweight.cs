using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlyweight : MonoBehaviour
{
    [SerializeField] private PlayerDataFlyweight playerData = null;
    Renderer _mRenderer;
    MaterialPropertyBlock _mPB;
    private void Awake()
    {
        _mRenderer = GetComponent<Renderer>();
        _mPB = new MaterialPropertyBlock();
        _mPB.SetColor("_Color", playerData.GetObjectRandomColor());
        _mRenderer.SetPropertyBlock(_mPB);
        // _mRenderer.material.color = playerData.GetObjectRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * playerData.maxSpeed);
    }
}
