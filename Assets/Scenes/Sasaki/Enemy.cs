using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject m_eneBullet = default;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void Shot()
    {
        var x =  Instantiate(m_eneBullet, this.transform.position, Quaternion.identity);
    }


}
