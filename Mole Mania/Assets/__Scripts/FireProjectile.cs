using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    [Header("Inscribed")]
    public float bulletSpeed;

    [Header("Dynamic")]
    public Vector3 targetPosition;

    void Update() {
        transform.position = Vector3.MoveTowards(
                transform.position, 
                targetPosition, 
                bulletSpeed * Time.deltaTime);
        if (transform.position == targetPosition) {
            Destroy(this.gameObject);
        }
    }

    // public void SET_TARGET_POSITION(Vector3 target) {
    //     targetPosition = target;
    // }

    // public void CREATE_BULLET(GameObject bullet, Vector3 startingPosition, Vector3 target) {
    //     Instantiate(bullet, startingPosition, bullet.transform.rotation);
    //     targetPosition = target;
    // }
}
