using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject m_eneBullet = default;

    public int m_eneLevel;

    int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = 1 + m_eneLevel;
    }

    public void Shot()
    {
        Instantiate(m_eneBullet, this.transform.position, Quaternion.identity);
    }

    public void Damage(int atkPoint, GameObject obj)
    {
        hp -= atkPoint;
        if(hp <= 0)
        {
            Destroy(obj);
        }
    }

}
