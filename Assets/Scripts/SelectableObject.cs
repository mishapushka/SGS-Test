using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    public GameObject SelectionIndicator;

    public virtual void Start() {
        SelectionIndicator.SetActive(false);
    }

    public virtual void Select() {
        SelectionIndicator.SetActive(true);
    }

    public virtual void UnSelect() {
        SelectionIndicator.SetActive(false);
    }
}
