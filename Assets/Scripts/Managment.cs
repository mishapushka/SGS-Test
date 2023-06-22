using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SelectionState {
    UnitsSelected,
    Frame,
    Other
}

public class Managment : MonoBehaviour
{
    public Camera Camera;
    public SelectableObject Hovered;
    public List<SelectableObject> ListOfSelected = new List<SelectableObject>();

    public SelectionState CurrentSelectionState;

    private void Update() {
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            if (hit.collider.GetComponent<SelectableColider>()) {
                SelectableObject hitSelectable = hit.collider.GetComponent<SelectableColider>().SelectableObject;
                if (Hovered) {
                    if (Hovered != hitSelectable) {  
                        Hovered = hitSelectable;
                    }
                } else {
                    Hovered = hitSelectable;
                }
            } else {
                UnHoverCurrent();
            }
        } else {
            UnHoverCurrent();
        }

        if (Input.GetMouseButtonUp(0)) {
            if (Hovered) {
                CurrentSelectionState = SelectionState.UnitsSelected;
                Select(Hovered);
            }
        }
    }

    void Select(SelectableObject selectableObject) {
        if (ListOfSelected.Contains(selectableObject) == false) {
            ListOfSelected.Add(selectableObject);
            selectableObject.Select();
        }
    }

    public void Unselect(SelectableObject selectableObject) {
        if (ListOfSelected.Contains(selectableObject)) {
            ListOfSelected.Remove(selectableObject);
        }
    }

    void UnHoverCurrent() {
        if (Hovered) {
            Hovered = null;
        }
    }
}
