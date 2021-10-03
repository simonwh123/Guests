using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcActivate : MonoBehaviour
{
    public GameObject player;
    public float distanceNumber;

    public void Update()
    {
        
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < distanceNumber)
        {
            GetComponent<Npc>().enabled = true;
        }
        else
        {
            GetComponent<Npc>().enabled = false;
        }
    }
}
