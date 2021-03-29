using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_FireSpeed : MonoBehaviour
{
    public GameObject playerBulletspawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            speedChange();
            Destroy(gameObject);
        }
    }

    public void speedChange()
    {
        //BulletSpawnerController speedAdd = new BulletSpawnerController();
        //speedAdd.bulletSnelheid += .1f;
        playerBulletspawner.GetComponent<BulletSpawnerController>().bulletSnelheid -= 0.1f;
    }
}
