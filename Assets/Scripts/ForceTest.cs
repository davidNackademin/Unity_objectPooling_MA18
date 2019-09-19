using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.left * 100);
    }

   
}
