using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public GameObject[] pontos;

    public float dist;

    private NavMeshAgent agente;

    private int i = 0;

    private void Awake()
    {
        agente = this.GetComponent<NavMeshAgent>();
        //int d = Random.Range(0, pontos.Lenght);
        agente.SetDestination(pontos[i].transform.position);
    }

    private void Update()
    {
        if (agente.remainingDistance < dist)
        {
            //int d = Random.Range(0,pontos.Length);
            i++;
            if (i < pontos.Length)
            {
                agente.SetDestination(pontos[i].transform.position);
            }
            else
            {
                i = 0;
                agente.SetDestination(pontos[i].transform.position);
            }
        }
        //Debug.Log(i);
    }
}
