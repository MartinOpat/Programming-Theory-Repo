using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShape : Shape
{
    void Start() {
        Init();
        shapeColor = Color.green;
        showColor();
    }
    
    public override void DisplayText() {
        textObject.SetText("You chose the green shape");
    }
}
