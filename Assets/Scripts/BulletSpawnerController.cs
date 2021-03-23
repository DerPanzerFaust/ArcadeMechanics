using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSpawnerController : MonoBehaviour
{

    //GameObject en variabelen berijkbaar binnen Unity.
    public GameObject Laser_p;
    public float bulletSnelheid = 0.5f;
    
    float timer = 0;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (timer > 0)
            {
                //de timer gaat omlaag met elke frame en stuurt dit dan weer terug.
                timer -= Time.deltaTime;
                return;
            }
            else
            {
                Shoot();
            }

            //reset de timer
            timer = bulletSnelheid;
        }
    }
    public void Shoot()
    {
        //er wordt hier een kopie gemaakt van de Prefab met de pos en rot van de Parent.
        GameObject bullet = Instantiate(Laser_p, transform.position, transform.rotation);
        //De bullet word vernietigt na 1.5sec
        Destroy(bullet, 1.5f);
    }
}
