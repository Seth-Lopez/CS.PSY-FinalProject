using UnityEngine;
using UnityEngine.InputSystem;

public class monoScript : MonoBehaviour
{
    public InputActionReference throwObject;
    public bool isHoldingTrigger = false;
    private DistanceGrabInteractor[] DGI;
    public bool primed = false;

    private void Start() 
    {
        DGI = FindObjectsOfType<DistanceGrabInteractor>();
    }
    private void Update()
    {
        foreach (DistanceGrabInteractor interactor in DGI)
        {
            if(interactor.isGrabbing == true)
            {
                if(isHoldingTrigger)
                {
                    primed = true;
                }
            }
        }
    }
    private void OnEnable()
    {
        try
        {
            throwObject.action.performed += OnThrowPerformed;
            throwObject.action.canceled += OnThrowCanceled;
        }
        catch{}
    }

    private void OnDisable()
    {
        try
        {
            throwObject.action.performed -= OnThrowPerformed;
            throwObject.action.canceled -= OnThrowCanceled;
        }
        catch{}
    }

    private void OnThrowPerformed(InputAction.CallbackContext context)
    {
        isHoldingTrigger = true;
    }

    private void OnThrowCanceled(InputAction.CallbackContext context)
    {
        isHoldingTrigger = false;
    }
}
