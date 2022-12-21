using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void Continue()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
