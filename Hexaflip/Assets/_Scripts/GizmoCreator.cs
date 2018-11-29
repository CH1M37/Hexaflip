using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoCreator : MonoBehaviour {

    public Color couleur;

    void OnDrawGizmos()
    {
        Gizmos.color = couleur;
        Gizmos.DrawSphere(transform.position, 1);
    }

}
