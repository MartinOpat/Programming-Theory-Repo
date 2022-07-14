using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GreenShape : Shape
{
    void Start() {
        Init();
        shapeColor = Color.green;
        showColor();
    }
    
    // POLYMORPHISM
    public override void DisplayText() {
        textObject.SetText("You chose the green shape");
    }
}
