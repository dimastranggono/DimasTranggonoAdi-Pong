using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int velocity;
    //variabel untuk ambil input Tombol keyboard yg diinginkan
    public KeyCode upButton;
    public KeyCode downButton;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }


    private Vector2 GetInput()
    {
        //it usually goes like this
        //if (Input.GetKey(KeyCode.W))
        //but now we use this
        if (Input.GetKey(upButton))
        {
            //cara 1
            //speed = new Vector2(0, 1);

            //cara 2
            return Vector2.up * velocity;
        }
        else if (Input.GetKey(downButton))
        {
            return Vector2.down * velocity;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 speed)
    {
        rb.velocity = speed; 
    }

}
