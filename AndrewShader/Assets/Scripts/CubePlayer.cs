using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CubePlayer : MonoBehaviour
{
    PlayerInput playerInput;
    Mover mover;
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<Mover>();
        var index = playerInput.playerIndex;
        mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }
    public void OnMove(InputValue value)
    {
        if (mover != null)
            mover.SetInputVector(value.Get<Vector2>());
    }
}
