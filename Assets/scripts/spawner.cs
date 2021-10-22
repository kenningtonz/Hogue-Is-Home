using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] tinyhogues;

    private float timebetweenspawn;
    public float starttimebetweenspawn;
    public float decreasetime;
    public float mintime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timebetweenspawn <= 0)
        {
            int rand = Random.Range(0, tinyhogues.Length );
            Instantiate(tinyhogues[rand], transform.position, Quaternion.identity);
            timebetweenspawn = starttimebetweenspawn;
            if (starttimebetweenspawn> mintime)
            starttimebetweenspawn -= decreasetime;
        }
        else
        {
            timebetweenspawn -= Time.deltaTime;
        }
    }
}
