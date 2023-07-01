using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class VBTN : MonoBehaviour
{

    public GameObject cube;
    public VirtualButtonBehaviour Vb;


    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }

}
