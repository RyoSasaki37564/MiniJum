using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject m_eneBullet = default;

    public int m_eneLevel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shot()
    {
        Instantiate(m_eneBullet, this.transform.position, Quaternion.identity);
    }

    /*
    void LevelUp(int getExp)
    {
        exp += getExp;
        if(exp >= list[level])
        {
            exp -= list[level];
            level++;
        }
    }
    */
}
