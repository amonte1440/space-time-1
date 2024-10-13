using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    [SerializeField]
    private float speed = 5f;
    public GameObject BulletTemplate;
    public float shootPower = 1000f;

    private GameObject playerTarget;
    // When the player enters the trigger, assign it as a target
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("MainCamera")) {
            playerTarget = other.gameObject;
            InvokeRepeating("Shoot", 0f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Only move forward if there is a player target
        if (playerTarget != null) {
                transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }

    void Shoot() {
        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
    }
}
