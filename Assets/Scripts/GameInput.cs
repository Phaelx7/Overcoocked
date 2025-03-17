using System;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public event EventHandler OnInteractAction;
    //Variavel Input
    private PlayerInputActions playerInputActions;
    void Awake()
    {   //Ativar o Input System
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Interact.performed += Interact_performed;
    }
    void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
        throw new System.NotImplementedException();
    }

    public Vector2 GetMovementVectorNormalized()
    {   //Deixar a movimentacao dos comandos mais fluida
        //Pega os botoes do Input System
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized; //Normaliza
        return inputVector; //Retorna depois de normalizar
    }
}