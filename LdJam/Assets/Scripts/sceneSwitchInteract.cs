using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitchInteract : MonoBehaviour
{
    public GameObject interactText;
    public bool touching = false;
    public string scene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            touching = true;
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            touching = false;
            interactText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (touching && Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
