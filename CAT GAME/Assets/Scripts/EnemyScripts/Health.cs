using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;
    public int CurrentHealth;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = Health;
    }

    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        Anim.SetTrigger("Hurt");

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Enemy Died");
        Anim.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
