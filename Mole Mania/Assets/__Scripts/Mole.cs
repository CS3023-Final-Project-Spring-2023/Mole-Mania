using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    // if mole is shot (collider is clicked)
    void OnMouseDown() {
        Score.moleHit();
    }
}
