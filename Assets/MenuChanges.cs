using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanges : MonoBehaviour {

    public GameObject menuOpciones;
    public GameObject menuAR;

    public void changeToAR()
    {
        menuOpciones.SetActive(false);
        menuAR.SetActive(true);
    }

    public void changeToOptions()
    {
        menuOpciones.SetActive(true);
        menuAR.SetActive(false);
    }
}
