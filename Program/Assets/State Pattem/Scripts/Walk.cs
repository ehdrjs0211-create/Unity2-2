using UnityEngine;
using UnityEngine.TextCore.Text;

public class Walk : IStateable
{
    public void Enter(Character character)
    {
        character.animator.SetInteger("X", 1);
        character.animator.SetInteger("Y", 1);
    }

    public void Exit(Character character)
    {
        character.animator.SetInteger("X", 0);
        character.animator.SetInteger("Y", 0);
    }

    public void Update(Character character)
    {
        int x = (int)Input.GetAxis("Horizontal");
        int y = (int)Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.Space))
        {
            character.SwitchState(new Attack());
        }
        if((x==0)&&(y==0))
        {
            character.SwitchState(new Idle());
        }
        character.animator.SetInteger("X", 1);
        character.animator.SetInteger("Y", 1);
    }
}
