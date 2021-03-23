using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.right * speed;
    }
}
