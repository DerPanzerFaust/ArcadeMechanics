using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{
    public GameObject firePartical;
    public float speed = 30;
    private float MinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        MinSpeed = speed - (speed * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            firePartical.SetActive(true);
            transform.position += new Vector3(0.0f, speed, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            firePartical.SetActive(true);
            transform.position += new Vector3(0.0f, MinSpeed, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            firePartical.SetActive(false);
            transform.position += new Vector3(MinSpeed, 0.0f, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            firePartical.SetActive(true);
            transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime;
        }


        //Omdat ik (Ryan) me iriteer dat ik de pijltjes niet kan gebruiken ):<
        if (Input.GetKey(KeyCode.UpArrow))
        {
            firePartical.SetActive(true);
            transform.position += new Vector3(0.0f, speed, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            firePartical.SetActive(true);
            transform.position += new Vector3(0.0f, MinSpeed, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            firePartical.SetActive(false);
            transform.position += new Vector3(MinSpeed, 0.0f, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            firePartical.SetActive(true);
            transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime;
        }
    }
}
