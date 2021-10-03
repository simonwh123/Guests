using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manager : MonoBehaviour
{
    public GameObject sleepImage;
    private GameObject ambience;

    // Start is called before the first frame update
    void Start()
    {
        ambience = GameObject.Find("Ambience");
        ambience.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("sleeping");
    }

    IEnumerator sleeping()
    {
        yield return new WaitForSeconds(12);
        sleepImage.SetActive(false);
        ambience.SetActive(true);
    }
}
