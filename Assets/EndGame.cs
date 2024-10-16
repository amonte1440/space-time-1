using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] 
    private GameObject endText;
    private bool endTextFlag = false;

    // Start is called before the first frame update
    void Start() 
    {
        endText.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!endTextFlag && AreAllEnemiesDestroyed()) {
            endText.SetActive(true);
            endTextFlag = true;
        }
    }

    private bool AreAllEnemiesDestroyed()
    {
        foreach (Transform child in transform)
        {
            if (child != null) return false;
        }
        return true;
    }
}
