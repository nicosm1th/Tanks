using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField]
    private TankMovement tankMovement;

    public void Accelerate()
    {
        tankMovement.Accelerate();
    }

    public void Deccelerate()
    {
        tankMovement.Deccelerate();
    }
}
