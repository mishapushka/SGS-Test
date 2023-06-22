using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private float _distanceToCollect = 2f;
    [SerializeField] private LayerMask _layerMask;

    void FixUpdate()
    {
        Collider[] collider = Physics.OverlapSphere(transform.position, _distanceToCollect, _layerMask, QueryTriggerInteraction.Ignore);
        for (int i = 0; i < collider.Length; i++) {
            if (collider[i].GetComponent<Loot>() is Loot loot) {

            }
        }
    }
}
