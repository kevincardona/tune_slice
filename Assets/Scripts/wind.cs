using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public float xDir = 1f;
    public float zSpeed = 1f;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(xDir, 0, zSpeed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
