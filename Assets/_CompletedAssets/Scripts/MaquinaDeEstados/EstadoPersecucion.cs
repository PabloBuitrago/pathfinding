using UnityEngine;
using System.Collections;

public class EstadoPersecucion : Estado {

    protected override void Awake()
    {
        base.Awake();
    }

    void OnEnable()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if(!controladorVision.PuedeVerAlJugador(out hit, true))
        {
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoAlerta);
            return;
        }

        controladorNavMesh.ActualizarPuntoDestino();
	}
}
