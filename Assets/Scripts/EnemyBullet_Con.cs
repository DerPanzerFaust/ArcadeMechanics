using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet_Con : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left * speed;
    }
}
