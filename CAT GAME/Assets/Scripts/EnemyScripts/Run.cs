using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : StateMachineBehaviour
{
    public float speed = 2.5f;
    Transform player;
    Rigidbody2D Rb;
    Flip Enemy;
    public float AttackRange = 3f;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Rb = animator.GetComponent<Rigidbody2D>();
        Enemy = animator.GetComponent<Flip>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Enemy.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, Rb.position.y);
        Vector2 NewPos = Vector2.MoveTowards(Rb.position, target, speed * Time.fixedDeltaTime);
        Rb.MovePosition(NewPos);

        if (Vector2.Distance(player.position, Rb.position) <= AttackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }


}
