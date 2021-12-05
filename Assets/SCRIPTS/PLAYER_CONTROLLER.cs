using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PLAYER_CONTROLLER : MonoBehaviour
{
    //TEXTO QUE PUEDE VARIAR SEGUN LA TECLA SELECCIONADA
    public TextMeshProUGUI arrowText;

    void Start()
    {
        //TEXTO DE INICIO
        arrowText.text = $"Pulsa cualquiera de las cuatro flechas";
    }

    void Update()
    {
        //TEXTO ASIGNADO SEGUN LA TECLA PULSADA
        ShowMessage(KeyCode.LeftArrow, $"Izquierda");
        ShowMessage(KeyCode.RightArrow, $"Derecha");
        ShowMessage(KeyCode.UpArrow, $"Arriba");
        ShowMessage(KeyCode.DownArrow, $"Abajo");
        ShowMessage(KeyCode.Return, $"¡Pium!");
    }

    //FUNCION CON KEYCODE Y STRING
    public void ShowMessage(KeyCode key, string message)
    {
        if (Input.GetKey(key))
        { arrowText.text = message; }
    }
}
