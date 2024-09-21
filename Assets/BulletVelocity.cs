using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVelocity : MonoBehaviour
{
    public float baseSpeed = 100f;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * baseSpeed * Time.deltaTime * Time.timeScale;
    }
}
