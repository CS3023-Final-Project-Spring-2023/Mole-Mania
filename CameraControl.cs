using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Vector3 defaultPos;
    private const float MAGNITUDE = 0.4f;
    // Start is called before the first frame update
    public void Shake(){
        StartCoroutine (routine:_shake());
    }

IEnumerator _shake()
for(int i =0; i<= 360; i+= 60){
    transform.position = new Vector3(this.defaultPos.x,this.defaultPos.y+MAGNITUDE*Mathf.Sin(f:i *Mathf.Deg2Rad),this.defaultPos.z);
    yield return null;

    start()
        
    this.defaultPos = transform.position;
}
}