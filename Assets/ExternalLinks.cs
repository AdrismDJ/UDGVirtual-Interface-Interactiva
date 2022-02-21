using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalLinks : MonoBehaviour
{
    public void OpenCreditos () {
        Application.OpenURL("https://es.wikipedia.org/wiki/Cr%C3%A9dito#:~:text=El%20cr%C3%A9dito%20o%20contrato%20de,intereses%20devengados%2C%20seguros%20y%20costos"); 
    }

        public void OpenInicio () {
        Application.OpenURL("https://es.wikipedia.org/wiki/Inicio"); 
    }

        public void OpenOpciones () {
        Application.OpenURL("https://es.wikipedia.org/wiki/Tipos_de_opciones"); 
    }
}
