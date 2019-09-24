using UnityEngine;

class BlockController : MonoBehaviour
{
    StateBase state;

    public void Start()
    {
        state = new WaitState(gameObject);
    }

    public void Update()
    {
        if (state.isComplate) state = state.nextState;
        state.Update();
    }

    public void Move(Vector3 move)
    {
        state.Move(move);
    }
}
