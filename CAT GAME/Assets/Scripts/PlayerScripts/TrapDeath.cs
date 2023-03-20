using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDeath : MonoBehaviour
{
    public Rigidbody2D Player;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
           
            Die();
        }
    }

    private void Die()
    {

        Player.bodyType = RigidbodyType2D.Static;
        GetComponent<Animator>().SetTrigger("Death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
