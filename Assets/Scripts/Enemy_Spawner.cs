using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject theEnemy;
    public float xPos;
    public float yPos;
    public int enemyCount;
    public bool waar = true;
    

    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        InvokeRepeating("StartSpawning", 2.0f, 2.0f);


    }
    private void Update()
    {
       
    }

    private void StartSpawning()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        while (enemyCount <= 3)
        {
                
            xPos = Random.Range(1.06f, 8.02f);
            yPos = Random.Range(-4.23f, 4.24f);
            Quaternion rot = Quaternion.Euler(0, 0, -90);
            GameObject obj = Instantiate(theEnemy, new Vector3(xPos, yPos, -3), rot);
            yield return new WaitForSeconds(0.1f);
            enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        }
    }

   
}
