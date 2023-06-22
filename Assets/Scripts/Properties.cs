using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : SelectableObject {
    
    private Color _startColor;
    public Renderer Renderer;

    private void Awake() {
        _startColor = Renderer.material.color;
    }


    public override void Select() {
        base.Select();
        Renderer.material.color = Color.red;
    }

    public override void UnSelect() {
        base.UnSelect();
        Renderer.material.color = _startColor;
    }
}
