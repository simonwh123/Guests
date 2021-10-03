using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectsOnTouch : MonoBehaviour
{
    public GameObject objectsToDeactivate;
    public GameObject objectsToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectsToActivate.SetActive(true);
            objectsToDeactivate.SetActive(false);
        }
    }
}
