using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementManeger : MonoBehaviour
{
    public ARRaycastManager raymanager;  // Gerenciador de raios para executar raycasts AR
    public GameObject PointObj;          // O objeto que será colocado no plano detectado

    void Start()
    {
        raymanager = FindObjectOfType<ARRaycastManager>();  // Encontra o ARRaycastManager na cena
        PointObj = this.transform.GetChild(0).gameObject;   // Obtém o primeiro filho do objeto atual (assumindo que seja o objeto de marcação)
        PointObj.SetActive(false);                          // Desativa o objeto de marcação no início
    }

    void Update()
    {
        List<ARRaycastHit> hitpoint = new List<ARRaycastHit>();  // Lista para armazenar informações dos raios AR acertados
        raymanager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hitpoint, TrackableType.Planes);
        // Executa um raio AR a partir do centro da tela e armazena o ponto de acerto em 'hitpoint'

        if (hitpoint.Count > 0)
        {
            transform.position = hitpoint[0].pose.position;    // Move este objeto para a posição do primeiro ponto de acerto
            transform.rotation = hitpoint[0].pose.rotation;    // Define a rotação deste objeto para a rotação do primeiro ponto de acerto
            if (!PointObj.activeInHierarchy)
            {
                PointObj.SetActive(true);                      // Ativa o objeto de marcação quando um plano é detectado
            }
        }
    }
}
