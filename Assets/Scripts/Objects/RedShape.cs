using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedShape : Shape
{
    void Start() {
        Init();
        shapeColor = Color.red;
        showColor();
    }
    
    // POLYMORPHISM
    public override void DisplayText() {
        textObject.SetText("You chose the red shape");
    }
}
