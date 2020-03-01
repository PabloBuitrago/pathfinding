using UnityEngine;
using System.Collections;

public class MaquinaDeEstados : MonoBehaviour {

    public Estado EstadoPatrulla;
    public Estado EstadoAlerta;
    public Estado EstadoPersecucion;
    public Estado EstadoInicial;

    public MeshRenderer meshRendererIndicador;

    private Estado estadoActual;

	// Use this for initialization
	void Start () {
        ActivarEstado(EstadoInicial);
	}

    public void ActivarEstado(Estado nuevoEstado)
    {
        if(estadoActual != null) estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;

        meshRendererIndicador.material.color = estadoActual.colorEstado;
    }
}
