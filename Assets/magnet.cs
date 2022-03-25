using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour
{
    public GameObject magnetObject;
    public float forcefactor;

    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce((magnetObject.transform.position - transform.position) * forcefactor * Time.deltaTime);   
    }
}
