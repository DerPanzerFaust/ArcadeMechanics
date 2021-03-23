using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject theEnemy;
    public float xPos;
    public float yPos;
    public int enemyCount;
    

    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        StartCoroutine(EnemyDrop()); 
    }
    private void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    IEnumerator EnemyDrop()
    {
      while (enemyCount < 3)
        {
            
            xPos = Random.Range(1.06f, 8.02f);
            yPos = Random.Range(-4.23f, 4.24f);
            Quaternion rot = Quaternion.Euler(0, 0, -90);
            GameObject obj = Instantiate(theEnemy, new Vector3(xPos, yPos, -3), rot);
            //obj.transform.rotation = Quaternion.Euler(0, 0, -90.0f);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;

        }
    }

   
}
