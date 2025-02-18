using UnityEngine;

public class PlayerController : MonoBehaviour{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;
    [SerializeField] private float jump;

    private Rigidbody rb;
    void Start(){
        inputManager.OnMove.AddListener(MovePlayer);
        inputManager.Jump.AddListener(onJump);
        rb=GetComponent<Rigidbody>();
        
    }
    void Update()
    {
     transform.rotation = Quaternion.Euler(0,transform.rotation.eulerAngles.y,0);   
    }

    private void MovePlayer(Vector3 direction){
        Vector3 moveDirection = new(direction.x, direction.y, direction.z);
        rb.AddForce(speed * moveDirection);

    }
    public void onJump(Vector3 input){
        rb.AddForce(input * jump,ForceMode.Impulse);
        
    }
}