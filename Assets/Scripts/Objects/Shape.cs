using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour {

    private MeshRenderer shapeRenderer;
    
    // ENCAPSULATION
    protected Color shapeColor;
    protected TextMeshProUGUI textObject { get; private set; }
    
    // ABSTRACTION
    protected void Init() {
        shapeRenderer = gameObject.GetComponent<MeshRenderer>();
        textObject = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
    }

    public virtual void DisplayText() {
        textObject.SetText("Basic Shape");
    }
    
    // ABSTRACTION
    protected void showColor() {
        shapeRenderer.material.color = shapeColor;
    }

    private void OnMouseDown() {
        Debug.Log("Here");
        if (Input.GetMouseButton(0)) {
            DisplayText();
        }
    }
}
