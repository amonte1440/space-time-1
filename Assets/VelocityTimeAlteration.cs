using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VelocityTimeAlteration : MonoBehaviour
{
    public InputActionReference pos;
    private Vector3 startPos;

    public float maxVelocity = 20f;
    public float minVelocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = pos.action.ReadValue<Vector3>();
;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = pos.action.ReadValue<Vector3>() - startPos;
        Vector3 currentVelocity = displacement / Time.deltaTime;
        startPos = pos.action.ReadValue<Vector3>();

        float velocityMagnitude = currentVelocity.magnitude;
        float timeScale = Mathf.InverseLerp(minVelocity, maxVelocity, velocityMagnitude);
        Time.timeScale = timeScale;
    }
}
