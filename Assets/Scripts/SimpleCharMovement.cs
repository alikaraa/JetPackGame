using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharMovement : MonoBehaviour
{
    
    float horMovement = 0;
    float verMovement = 0;
  
    
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        
        horMovement += hor * Time.deltaTime * 5;
        verMovement += ver * Time.deltaTime * 5;
        transform.position = new Vector3(-horMovement, transform.position.y, -verMovement);
        
    }
}
