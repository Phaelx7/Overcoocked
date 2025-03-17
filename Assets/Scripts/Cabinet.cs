using UnityEngine;

public class Cabinet : MonoBehaviour
{
    [SerializeField]private Transform objectPrefab; //Objeto que sera spawnado
    [SerializeField]private Transform objectSpawn; //Local que vai aparecer

    void OnCollisionEnter3D(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            //Chama o metodo
            Debug.Log("Interact");
            Interact();
        }
    }
    public void Interact()
    {
        Debug.Log("Interact");
        Transform objetoTransform = Instantiate(objectPrefab, objectSpawn);
        objetoTransform.localPosition = Vector3.zero;
    }
}
