using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class acciones : MonoBehaviour
{
    [SerializeField] private VirtualButtonBehaviour virtualButton;
    public UnityEvent OnButtonPressed;
    public UnityEvent OnButtonReleased;
    
    private void OnEnable()
    {
        virtualButton.RegisterOnButtonPressed(ButtonPressed);
        virtualButton.RegisterOnButtonReleased(ButtonReleased);
    }

    private void OnDestroy()
    {
        virtualButton.UnregisterOnButtonPressed(ButtonPressed);
        virtualButton.UnregisterOnButtonReleased(ButtonReleased);
    }

    private void ButtonPressed(VirtualButtonBehaviour button)
    {
        OnButtonPressed?.Invoke();
        Debug.Log("Boton Presionado");
    }

    private void ButtonReleased(VirtualButtonBehaviour button)
    {
        OnButtonReleased?.Invoke();
        Debug.Log("Button Released");
    }
}