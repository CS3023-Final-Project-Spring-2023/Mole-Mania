/*****
 * Created by: Nathan Nguyen
 * Created on: ---
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 5/4/2023
 * 
 * Description: Raycasts and find a world position to shoot the bullet. Also rotates the gun to world position mouse is at.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDetector : MonoBehaviour
{
    private Vector3 bulletSpawnPosition; 

    [Header("Inscribed")]
    public LayerMask layersToHit;
    public GameObject bullet;
    public float speed;

    [Header("Dynamic")]
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    public Vector3 screenPositionRotate;
    public Vector3 worldPositionRotate;

    private Transform gunParent;

    void Start() {
        speed = 5.0f;
        gunParent = transform.parent;
    }

    void Update() {

        screenPositionRotate = Input.mousePosition;

        Ray rotateRay = Camera.main.ScreenPointToRay(screenPositionRotate);

        if (Physics.Raycast(rotateRay, out RaycastHit hitDataRotate, 100, layersToHit)) {
            worldPositionRotate = hitDataRotate.point;
        }

        Vector3 newDirection = (worldPositionRotate - gunParent.position).normalized;
        Debug.DrawRay(gunParent.position, newDirection, Color.red);

        gunParent.rotation = Quaternion.LookRotation(newDirection, Vector3.up);

        // Shoots bullet towards raycast position
        if (Input.GetMouseButtonDown(0)) {
            bulletSpawnPosition = transform.GetChild(1).position;

            screenPosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(screenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitData, 100, layersToHit)) {
                worldPosition = hitData.point;
            }

            GameObject go = Instantiate(bullet, bulletSpawnPosition, bullet.transform.rotation).gameObject;
            go.GetComponent<FireProjectile>().targetPosition = worldPosition;
        }
    }

}
