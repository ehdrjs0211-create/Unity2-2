using UnityEngine;

public class Knife : Weapon
{
    [SerializeField] Animator animator;
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public override void Attack()
    {
        animator.Play("Attack");
    }
}
