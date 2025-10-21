using UnityEngine;
using UnityEngine.InputSystem;

public class EthanController_1D : MonoBehaviour
{

    //public InputActionAsset inputActions;

    //public InputAction accion_move;

    private Animator _mechanim;

    private InputSystem_Actions _inputActions;
    private float _acceleration = 1;
    private float _speed;

    private void OnEnable()
    {
        

        if (_inputActions == null)
        {
            _inputActions = new InputSystem_Actions();
        }
        _inputActions.Player.Enable();
        //inputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {

        if (_inputActions != null)
        {
            _inputActions.Player.Disable();
        }

        //inputActions.FindActionMap("Player").Disable();
    }

    
    void Start()
    {
        
        _mechanim = GetComponent<Animator>();
        //accion_move = InputSystem.actions.FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = _inputActions.Player.Move.ReadValue<Vector2>();
        _speed = Mathf.Lerp(_speed, move.y, _acceleration * Time.deltaTime);



        _mechanim.SetFloat("Speed",_speed);
    }



}
