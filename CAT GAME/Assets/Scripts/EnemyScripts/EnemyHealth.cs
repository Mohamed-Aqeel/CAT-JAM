using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    public int CurrentHealth;
    public Animator Anim;

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        Anim.SetTrigger("Hurt");

        if (health <= 0)
        {
            Invoke("Die", 2);
        }
    }

    void Die()
    {
        GetComponent<Animator>().SetBool("Death", true);
        Destroy(gameObject);
    }
}
