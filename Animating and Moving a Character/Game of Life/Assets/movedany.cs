using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedany : MonoBehaviour
{
    public float speed = 4;
    public Rigidbody2D rigidbody1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rigidbody1.velocity = new Vector2(move * speed, 0);
    }
}
