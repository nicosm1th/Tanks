using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private Tank target;

    // _ w/ variable = temp or hidden
    public PlayerController(Tank _Target)
    {
        target = _Target;
    }

    public void Accelerate ()
    {
        target.Accelerate();
    }

    public void Deccelerate ()
    {
        target.Deccelerate();
    }
}

