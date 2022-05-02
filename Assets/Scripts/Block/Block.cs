using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject slicedBlock;
    public string color = "blue";
    public float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, speed);
    }

    private void OnTriggerEnter(Collider col)
    {
        Vector3 direction = (col.transform.position - transform.position).normalized;
        var sliced = Instantiate(slicedBlock, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(sliced, 3f);
    }
}
