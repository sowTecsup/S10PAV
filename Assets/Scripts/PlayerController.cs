using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    public PlayerInputs playerInputs;
    void Start()
    {
        playerInputs.OnTryingToAttack += ShootMechanism;
        
    }

    void Update()
    {
        
    }
    private void ShootMechanism()
    {
        print("Pew pew");
    }
}
