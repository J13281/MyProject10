using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class ButtonController : MonoBehaviour
{
    public void OnClick()
    {
        if (name == "up")
        {
            MainController.instance.Move(Vector3.up);
        }
        else if (name == "down")
        {
            MainController.instance.Move(Vector3.down);
        }
    }
}
