using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject blueCube;
    public GameObject redCube;

    void Start()
    {
        
    }

    float i;
    void FixedUpdate()
    {
        if (Time.time > i)
        {
            i += 1f;
            Instantiate(blueCube, new Vector3(0.3f, 1f, 8f), Quaternion.identity);
        }
    }
}
