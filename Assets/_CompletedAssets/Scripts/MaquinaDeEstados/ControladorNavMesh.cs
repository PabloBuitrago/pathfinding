using UnityEngine;
using System.Collections;

public class ControladorNavMesh : MonoBehaviour {

    [HideInInspector]
    public Transform perseguirObjetivo;

    private UnityEngine.AI.NavMeshAgent navMeshAgent;

	void Awake() {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	public void ActualizarPuntoDestino(Vector3 puntoDestino) {
        navMeshAgent.destination = puntoDestino;
        navMeshAgent.Resume();
	}

    public void ActualizarPuntoDestino()
    {
        ActualizarPuntoDestino(perseguirObjetivo.position);
    }

    public void Detener()
    {
        navMeshAgent.Stop();
    }

    public bool HemosLlegado()
    {
        return navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && !navMeshAgent.pathPending;
    }
}
