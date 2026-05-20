using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BalloonScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Destroy());
    }
    void Update()
    {
        transform.Translate(Vector3.up*Time.deltaTime*0.2f);
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
        StartCoroutine(Destroy());
    }
}
