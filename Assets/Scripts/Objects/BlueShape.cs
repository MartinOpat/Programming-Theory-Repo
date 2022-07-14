using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShape : Shape
{
    void Start() {
        Init();
        shapeColor = Color.blue;
        showColor();
    }

    public override void DisplayText() {
        textObject.SetText("You chose the blue shape");
    }
}
