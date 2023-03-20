using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator Anim;
    public Transform ATKPoint;
    public float ATKRange = 0.5f;
    public LayerMask EnemyLayers;
    public int ATKDamage = 100;
    public float ATKRate = 2f;
    public float NextATKTime = 0f;
    public Vector3 attackOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= NextATKTime)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                ATK();
                NextATKTime = Time.time + 1 / ATKRate;
            }
        }
    }


    void ATK()
    {

        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Collider2D colInfo = Physics2D.OverlapCircle(ATKPoint.position, ATKRange, EnemyLayers);
        if (colInfo != null)
        {
           // colInfo.GetComponent<Enemy>().TakeDamage(ATKDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        if (ATKPoint == null)
            return;

        Gizmos.DrawWireSphere(ATKPoint.position, ATKRange);
    }
}
