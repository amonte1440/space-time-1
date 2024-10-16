using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2.0f;
    private bool enemyDestroyedFlag = false;

    private Transform player;
    private GameObject plane;

    // Start is called before the first frame update
    private void Start()
    {
        player = Camera.main.transform.parent;
        plane = GameObject.Find("Plane");
    }

    // Update is called once per frame
    private void Update()
    {
        if (!enemyDestroyedFlag && enemyDestroyCheck())
        {
            enemyDestroyedFlag = true;
        }
        if (enemyDestroyedFlag)
        {
            MoveUp();
        }
    }

    private bool enemyDestroyCheck()
    {
        foreach (Transform child in transform)
        {
            if (child != null) return false;
        }
        return true;
    }

    private void MoveUp()
    {
        if (player != null && player.position.y < 26.85f)
        {
            player.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }

        if (plane != null && plane.transform.position.y < 25.85f)
        {
            plane.transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
    }
}
