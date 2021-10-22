using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Vector3 newposition;
    public float yinc;
    public float speed;
    public int health = 3;
    public Text Healthdisplay;

    public float maxhight, minheight;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Healthdisplay.text = health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene("game over");
            Destroy(gameObject);
            health = 3;
        }

        transform.position = Vector3.MoveTowards(transform.position, newposition, speed * Time.deltaTime);

        if (Input.GetKeyDown("w") && transform.position.y < maxhight)
        {
            newposition = new Vector3(transform.position.x, transform.position.y + yinc, 0);
        }
        if (Input.GetKeyDown("s") && transform.position.y > minheight)
        {
            newposition = new Vector3(transform.position.x, transform.position.y - yinc, 0);
        }


    }
}
