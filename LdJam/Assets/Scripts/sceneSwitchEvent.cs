﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitchEvent : MonoBehaviour
{
    public void switchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
