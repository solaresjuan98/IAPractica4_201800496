using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualBtn : MonoBehaviour
{
    // * Opciones del menu
    public GameObject opt_cs;

    public VirtualButtonBehaviour Vb;

    void Start()
    {

        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        opt_cs.SetActive(true);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        opt_cs.SetActive(true);
        Debug.Log("Presionando");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        opt_cs.SetActive(false);
        Debug.Log("No presionando");
        // Aquí puedes implementar alguna lógica adicional si es necesario cuando se suelta el botón
    }
}
