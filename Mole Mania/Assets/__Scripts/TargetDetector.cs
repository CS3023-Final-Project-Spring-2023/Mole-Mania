/*****
 * Created by: Nathan Nguyen
 * Created on: 
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 4/24/23
 * 
 * Description: Determines where to shoot the bullet and and sends it the created bullet.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDetector : MonoBehaviour
{
    public Vector3 startingPosition; 

    [Header("Inscribed")]
    public LayerMask layersToHit;
    public GameObject bullet;

    [Header("Dynamic")]
    public Vector3 screenPosition;
    public Vector3 worldPosition;

    void Awake() {
        startingPosition = transform.position;
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            screenPosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(screenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitData, 100, layersToHit)) {
                worldPosition = hitData.point;
            }

            GameObject go = Instantiate(bullet, startingPosition, bullet.transform.rotation).gameObject;
            go.GetComponent<FireProjectile>().targetPosition = worldPosition;
        }
    }

}
