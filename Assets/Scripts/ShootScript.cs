using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootScript : MonoBehaviour
{
   
    public GameObject arCamera;
    
    public void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(
            arCamera.transform.position, 
            arCamera.transform.forward, 
            out hit))
        {
            if(hit.transform.name == "Capsule01(Clone)" ||
            hit.transform.name == "Capsule02(Clone)" ||
            hit.transform.name == "Capsule03(Clone)")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
