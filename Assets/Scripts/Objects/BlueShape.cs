using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueShape : Shape
{
    void Start() {
        Init();
        shapeColor = Color.blue;
        showColor();
    }
    
    // POLYMORPHISM
    public override void DisplayText() {
        textObject.SetText("You chose the blue shape");
    }
}
