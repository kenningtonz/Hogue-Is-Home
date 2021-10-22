using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoguespawn : MonoBehaviour
{
    public GameObject bighogue;

    void Start()
    {
        Instantiate(bighogue, transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
