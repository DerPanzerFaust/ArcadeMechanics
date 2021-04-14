using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision : MonoBehaviour
{
    public GameObject explosionPartical;
    private AudioSource EnemyHit;

    // Start is called before the first frame update
    void Start()
    {
        //explosionPartical.SetActive(false);
        EnemyHit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            EnemyHit.Play();
            Score.scoreValue += 10;
            

            GameObject explotion = (Instantiate(explosionPartical, this.transform.position, this.transform.rotation)).gameObject;
            Destroy(explotion, 2f);

            Destroy(col.gameObject);

            Destroy(gameObject);
        }

    }
}
