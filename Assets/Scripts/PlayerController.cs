using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    public void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Update()
    {
        var move = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical"));

        characterController.SimpleMove(move);
    }
}
