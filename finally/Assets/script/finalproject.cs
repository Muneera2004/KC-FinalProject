using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalproject : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
    }
}
