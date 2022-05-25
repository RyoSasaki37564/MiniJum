using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Tooltip("弾のプレハブ")]
        GameObject _bullet;
    [SerializeField, Tooltip("体力")]
        int _hp;
    [SerializeField, Tooltip("攻撃力")]
        int _attak;
    [SerializeField, Tooltip("移動速度")]
        float _moveSpeed;
    [SerializeField, Tooltip("次のレベルまでの必要経験値")]
        List<int> _requiredExp = new List<int>();

    [Tooltip("進行方向　1が上、-1が下")]
        private int _dir;
    [Tooltip("現在の経験値")]
        private int _exp;
    [Tooltip("現在のレベル")]
        private int _level;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _dir = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = Vector3.up * _dir * _moveSpeed;
    }

    private void GetExp(int getExp)
    {
        _exp += getExp;

        if(_exp >= _requiredExp[_level])
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        _exp -= _requiredExp[_level];
        _level++;
    }

    private void Shot()
    {
        Instantiate(_bullet, this.transform.position, Quaternion.identity);
    }

    public void OnDamaged(int damage)
    {
        _hp -= damage;
    }
}
