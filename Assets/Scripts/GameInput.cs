using UnityEngine;

public class GameInput : MonoBehaviour
{
    //Variavel Input
    private PlayerInputActions playerInputActions;
    void Awake()
    {   //Ativar o Input System
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {   //Deixar a movimentacao dos comandos mais fluida
        //Pega os botoes do Input System
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized; //Normaliza
        return inputVector; //Retorna depois de normalizar
    }
}