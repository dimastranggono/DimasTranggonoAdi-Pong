using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    
    public Vector2 speed;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //cara satu
        //transform.position = transform.position + (new Vector3(1f,0,0) * Time.deltaTime);
        //
        //cara dua
        //transform.Translate(new Vector3(1f, 0, 0) * Time.deltaTime);
        //
        //cara tiga

       

        //transform.Translate(speed * Time.deltaTime);
    }
}
