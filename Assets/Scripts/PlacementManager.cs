using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementManeger : MonoBehaviour
{
    public ARRaycastManager raymanager;  // Gerenciador de raios para executar raycasts AR
    public GameObject PointObj;          // O objeto que ser� colocado no plano detectado

    void Start()
    {
        raymanager = FindObjectOfType<ARRaycastManager>();  // Encontra o ARRaycastManager na cena
        PointObj = this.transform.GetChild(0).gameObject;   // Obt�m o primeiro filho do objeto atual (assumindo que seja o objeto de marca��o)
        PointObj.SetActive(false);                          // Desativa o objeto de marca��o no in�cio
    }

    void Update()
    {
        List<ARRaycastHit> hitpoint = new List<ARRaycastHit>();  // Lista para armazenar informa��es dos raios AR acertados
        raymanager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hitpoint, TrackableType.Planes);
        // Executa um raio AR a partir do centro da tela e armazena o ponto de acerto em 'hitpoint'

        if (hitpoint.Count > 0)
        {
            transform.position = hitpoint[0].pose.position;    // Move este objeto para a posi��o do primeiro ponto de acerto
            transform.rotation = hitpoint[0].pose.rotation;    // Define a rota��o deste objeto para a rota��o do primeiro ponto de acerto
            if (!PointObj.activeInHierarchy)
            {
                PointObj.SetActive(true);                      // Ativa o objeto de marca��o quando um plano � detectado
            }
        }
    }
}
