using UnityEngine;

public class Player : MonoBehaviour
{
    //Variaveis
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private GameInput gameInput;
    private bool isWalking;

    void Start()
    {
        gameInput.OnInteractAction += GameInput_OnInteractAction;
    }
    void GameInput_OnInteractAction(object sender, System.EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    void Update()
    {
        Movement();
    }
    void Interactions() //Metodo de interacao
    {

    }
    void Movement() //Metodo de movimentacao
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y); //Direcionar
        transform.position += moveDir * moveSpeed * Time.deltaTime; //Andar

        isWalking = (moveDir != Vector3.zero);
        float rotateSpeed = 10f; //Velocidade de rotacao
        //Rotacao mais fluida
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
    }
    public bool IsWalking() //Metodo para verificar se esta andando
    {
        return isWalking; //Retorna
    }
}