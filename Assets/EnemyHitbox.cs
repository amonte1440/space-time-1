using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("PlayerBullet") || other.CompareTag("Sword")) {
            Destroy(transform.parent.gameObject);
        }
    }
}
