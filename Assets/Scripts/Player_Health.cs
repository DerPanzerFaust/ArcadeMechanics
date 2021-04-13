using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public Healtbar healthbar;
    private AudioSource PlayerHit;
    public GameObject GameOver;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxhealth(maxHealth);
        PlayerHit = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(gameObject.tag == "Enemy_Bullet")
        {
            TakeDamage(20);
            PlayerHit.Play();
        }
        if(gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            PlayerHit.Play();
        }
        healthbar.SetHealth(currentHealth);
        if(currentHealth == 0)
        {
            Destroy(gameObject);
            GameOver.SetActive(true);
        }
    }
    
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            PlayerHit.Play();
        }
    }
}
