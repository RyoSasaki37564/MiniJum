using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Bullet : MonoBehaviour
{
    [SerializeField] float m_point;

    [SerializeField] bool m_isPlayerBullet = false;

    float m_speed;

    Rigidbody2D m_rb;

    // Start is called before the first frame update
    void Start()
    {
        if (m_isPlayerBullet)
        {
            m_speed = -m_speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.velocity = new Vector2(m_speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!m_isPlayerBullet)
        {
            //敵の弾の処理
            if(collision.tag == "Wall")
            {

            }
        }
        else
        {
            //プレイヤーの弾の処理
            if (collision.tag == "EnemyBullet")
            {

            }

        }
    }
}
