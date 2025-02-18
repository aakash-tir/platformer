using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour{

    public UnityEvent OnSpacePressed = new UnityEvent();
    public UnityEvent<Vector3> OnMove= new UnityEvent<Vector3>();
    void Update(){
        
        Vector3 input = Vector3.zero;
        if (Input.GetKey(KeyCode.A)){
            input+=Vector3.left;
            Debug.Log("move player left");
        }
        if (Input.GetKey(KeyCode.D)){
            input+=Vector3.right;
            Debug.Log("move player left");
        }
        if (Input.GetKey(KeyCode.W)){
            input+=Vector3.forward;
            Debug.Log("move player forward");
        }
        if (Input.GetKey(KeyCode.W)){
            input+=Vector3.back;
            Debug.Log("move player backward");
        }
         OnMove?.Invoke(input);
        if (Input.GetKeyDown(KeyCode.Space)){
            OnSpacePressed?.Invoke();
        }

    }
}