using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject m_eneBullet = default;

    //[SerializeField] GameObject m_ojisanKobun = default;

    public void Shot()
    {
    //    var i = Random.Range(0, 10);
    //    if(i < 2)
    //    {
    //        Instantiate(m_ojisanKobun, this.transform.position, Quaternion.identity);
    //    }
    //    else
    //    {
            Instantiate(m_eneBullet, this.transform.position, Quaternion.identity);
        //}
    }
}
