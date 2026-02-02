using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;

    [SerializeField] IStateable stateable;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        stateable = new Idle();
    }

    // Update is called once per frame
    void Update()
    {
        stateable.Update(this);
    }

    public void SwitchState(IStateable state)
    {
        stateable?.Exit(this);

        stateable = state;

        stateable?.Exit(this);
    }
}
