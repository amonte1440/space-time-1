using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float amplitude = 5f;
    public float frequency = 1f;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float xOffset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPos.x + xOffset, startPos.y, startPos.z);
    }

    void OnCollisionEnter(Collision collision) 
    {
        Destroy(gameObject);
    }
}
