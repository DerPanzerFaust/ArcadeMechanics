using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner_Con : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Update is called once per frame
    void Update()
    {
        float RandNumb = Random.Range(1, 1000);
        if(RandNumb == 1)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        //er wordt hier een kopie gemaakt van de Prefab met de pos en rot van de Parent.
        GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        bullet.transform.position += new Vector3(-1f, 0f, 0f);
        //De bullet word vernietigt na 1.5sec
        Destroy(bullet, 1.5f);
    }
}
