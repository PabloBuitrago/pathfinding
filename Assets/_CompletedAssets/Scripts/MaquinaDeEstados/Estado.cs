using UnityEngine;
using System.Collections;

public class Estado : MonoBehaviour {

    public Color colorEstado;

    protected MaquinaDeEstados maquinaDeEstados;
    protected ControladorNavMesh controladorNavMesh;
    protected ControladorVision controladorVision;

    protected virtual void Awake()
    {
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();
        controladorVision = GetComponent<ControladorVision>();
    }

}
