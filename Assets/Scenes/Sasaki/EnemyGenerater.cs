using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerater : MonoBehaviour
{
    [SerializeField] float m_minTime, m_maxTime;

    float m_time = default;

    [SerializeField] Enemy m_enemyIcon = default;

    int m_nowLevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        ReActor();
    }

    IEnumerator EneGene(float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(m_enemyIcon, this.gameObject.transform.position, Quaternion.identity);
        m_enemyIcon.m_eneLevel = m_nowLevel;
        ReActor();
    }

    void ReActor()
    {
        int rand = Random.Range(0, 8);
        if(rand == 1)
        {
            m_nowLevel++;
            Debug.LogWarning($"Now Level Up {m_nowLevel}.");
        }
        m_time = Random.Range(m_minTime, m_maxTime);
        Debug.Log(m_time);
        StartCoroutine(EneGene(m_time));
    }
}
