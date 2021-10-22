using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinyhogue : MonoBehaviour
{
    private shakw shake;
    //public GameObject bighogue;
    public int damage = 1;
    public float speed = 2;

    public GameObject effect;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("screenshake").GetComponent<shakw>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("Player"))
        {
            shake.camshake();
            other.GetComponent<player>().health -= damage;
            Debug.Log(other.GetComponent<player>().health);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -10)
        {
         //   Destroy(gameObject);
        }
    }
}
