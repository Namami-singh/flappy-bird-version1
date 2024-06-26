using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    private float rate=3;
    private float time = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
       spawnPipe();
    }

    // Update is called once per frame
    void Update()  
    {
        if (time < rate)
        {
            time += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            time = 0;
        }
       
    }
    void spawnPipe()
    {
        float low= transform.position.y - heightoffset;
        float high = transform.position.y+ heightoffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(low,high),0), transform.rotation);
    }
}
