using UnityEngine;

class WaitState : StateBase
{
    public WaitState(GameObject block) : base(block) { }

    public override void Move(Vector3 move)
    {
        Transition(new MoveState(block, move));
    }
}
