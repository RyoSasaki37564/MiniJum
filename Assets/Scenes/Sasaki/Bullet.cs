using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Bullet : MonoBehaviour
{
    [SerializeField] int m_point;

    [SerializeField] bool m_isPlayerBullet = false;

    float m_speed = 1f;

    Rigidbody2D m_rb;


    public static int m_eneLevel = 0;

    int hp;

    Player m_p;

    public Enemy m_e;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();

        if (m_isPlayerBullet == true)
        {
            m_speed = -m_speed;
        }
        else
        {
            hp = 1 + m_eneLevel;
            m_p = FindObjectOfType<Player>().GetComponent<Player>();
        }

    }
    private void OnEnable()
    {
        if(!m_isPlayerBullet)
        {

        }
    }

    private void OnDisable()
    {
        if (!m_isPlayerBullet)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.velocity = new Vector2(m_speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(m_isPlayerBullet == false)
        {
            //敵の弾の処理
            if(collision.tag == "Wall")
            {
                m_p.OnDamaged(m_point);
                Destroy(this.gameObject);
            }
            else if (collision.tag == "PlayerBullet")
            {
                Damage(m_point);
            }
        }
        else
        {
            //プレイヤーの弾の処理
            if (collision.tag == "Wall")
            {
                Destroy(this.gameObject);
            }
        }
    }

    void Damage(int atkPoint)
    {
        if (!m_isPlayerBullet)
        {
            hp -= atkPoint;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
