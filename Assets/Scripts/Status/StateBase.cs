using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

abstract class StateBase
{
    public bool isComplate;
    public StateBase nextState;

    protected GameObject block;

    protected StateBase(GameObject block)
    {
        this.block = block;
    }

    public virtual void Init() { }
    public virtual void End() { }

    public virtual void Update() { }
    public virtual void Move(Vector3 move) { }

    public void Transition(StateBase nextState)
    {
        this.nextState = nextState;
        isComplate = true;
        End();
        nextState.Init();
        Debug.Log($"{GetType().Name} -> {nextState.GetType().Name}");
    }
}
