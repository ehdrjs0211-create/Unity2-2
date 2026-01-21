using UnityEngine;

public class Rifle : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform createPosition;
    public override void Attack()
    {
        Instantiate(bullet, createPosition);
    }

}
