using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanage : MonoBehaviour
{
    public Text scoredisplay;
    public int score;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("tinyhogue"))
        {
            score++;
            Debug.Log(score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoredisplay.text = score.ToString();
    }
}
