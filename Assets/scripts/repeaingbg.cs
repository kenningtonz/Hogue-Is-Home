using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeaingbg : MonoBehaviour
{

     float speed = 2;
     float endX = -21;
     float startX = 21;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }

            }
}
