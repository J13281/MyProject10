using System;
using UnityEngine;

class MoveState : StateBase
{
    float a;
    Vector3 move;
    Vector3 source;

    public MoveState(GameObject block, Vector3 move) : base(block)
    {
        this.move = move;
    }

    public override void Init()
    {
        source = block.transform.position;
    }

    public override void Update()
    {
        if (a < 1)
        {
            block.transform.position = source + a * move;
        }
        else
        {
            Transition(new WaitState(block));
        }

        a = easingNext(a);
    }

    public static float easingNext(float f)
    {
        return Math.Min(1, f + 0.05f);
    }
}
