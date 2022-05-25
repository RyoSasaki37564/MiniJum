using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerater : MonoBehaviour
{
    [SerializeField] float m_minTime, m_maxTime;

    float m_time = default;

    [SerializeField] GameObject m_enePos = default;

    [SerializeField] Enemy m_enemyIcon = default;

    [SerializeField] GameObject[] m_posList = new GameObject[4];

    int m_nowPosIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        ReActor();
    }

    IEnumerator EneGene(float time)
    {
        yield return new WaitForSeconds(time);
        m_enePos.transform.position = m_posList[m_nowPosIndex].transform.position;

        ReActor();
    }

    void ReActor()
    {
        int rand = Random.Range(0, 8);
        m_nowPosIndex = rand / 2;
        if(rand == 1)
        {
            Bullet.m_eneLevel++;
            Debug.LogWarning($"Now Level Up {Bullet.m_eneLevel}.");
        }
        m_time = Random.Range(m_minTime, m_maxTime);
        Debug.Log(m_time);
        StartCoroutine(EneGene(m_time));
    }
}
