using UnityEngine;
using System.Collections;

public class EstadoAlerta : Estado {

    public float velocidadGiroBusqueda = 120f;
    public float duracionBusqueda = 4f;

    private float tiempoBuscando;

    protected override void Awake()
    {
        base.Awake();
    }

    void OnEnable()
    {
        controladorNavMesh.Detener();
        tiempoBuscando = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (controladorVision.PuedeVerAlJugador(out hit))
        {
            controladorNavMesh.perseguirObjetivo = hit.transform;
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPersecucion);
            return;
        }

        transform.Rotate(0f, velocidadGiroBusqueda * Time.deltaTime, 0f);
        tiempoBuscando += Time.deltaTime;
        if(tiempoBuscando >= duracionBusqueda)
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPatrulla);
            return;
        }
	}
}
