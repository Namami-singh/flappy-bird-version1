using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D rigid1;
    public float strength;
    public logicscript logic1;
    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic1 = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
       { rigid1.velocity = Vector2.up * strength; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic1.Gameover();

    }
}

