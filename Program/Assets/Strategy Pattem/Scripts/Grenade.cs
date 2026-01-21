using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Grenade : Weapon
{
    [SerializeField] float throwPower;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 startPosition;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        startPosition = rigidbody.position;
    }
    public override void Attack()
    {
        if(rigidbody.useGravity == false)
        {
            rigidbody.useGravity = true;

            rigidbody.AddForce(direction.normalized*throwPower,ForceMode.Impulse);
        }
    }

    //OnBecameInvisible 어느 카메라에서든 랜더러가 더 이상 표시되지 않는경우 호출됨
    private void OnBecameInvisible()
    {
        rigidbody.useGravity = false;
        rigidbody.position = startPosition;
        rigidbody.linearVelocity = Vector3.zero;
    }

}
