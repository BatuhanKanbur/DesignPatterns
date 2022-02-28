using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="PlayerData",menuName ="Player Data")]
[ExecuteInEditMode]
public class PlayerDataFlyweight : ScriptableObject
{
    Color[] _colors = new Color[5] { Color.red, Color.white, Color.blue, Color.yellow, Color.green };
    public float _maxSpeed = 10;
    public float _maxHealth = 100;
    public float _attackDamage = 10;
    public float _attackRange = 25;

    public float maxSpeed=>_maxSpeed;
    public float maxHealth => _maxHealth;
    public float attackDamage => _attackDamage;
    public float attackRange => _attackRange;
    public Color GetObjectRandomColor()
    {
        Color _newColor = _colors[Random.Range(0, _colors.Length)];
        return _newColor;
    }
}
