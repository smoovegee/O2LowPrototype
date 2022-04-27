using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float curHealth;
    public int maxHealth = 100;

    public HealthBar healthBar;


    void Start()
    {
        curHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamagePlayer(1);
        }
        */
      
    }

    //had to change to float as needs to return float
    public float GetCurrentHealth()
    {
        //function called return which outputs value to caller
        return curHealth;
    }

    public void AddHealth(float healthAmount)
    {
        curHealth += healthAmount;
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage * Time.deltaTime;

        healthBar.SetHealth(curHealth);

        if (curHealth <= 0)
        {
            EndGame();
        }

    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Death");
    }
}

