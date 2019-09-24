using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public static MainController instance;

    // inject
    public GameObject block;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(Vector3 move)
    {
        block.SendMessage("Move", move);
    }
}
