using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Rigidbody2D Player;

    public void TakeDamage(int damage)
    {
        health -= damage;


        if (health <= 0)
        {
            Player.bodyType = RigidbodyType2D.Static;
            GetComponent<Animator>().SetTrigger("Death");
            Invoke("Die", 2);
        }
    }

    void Die()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
