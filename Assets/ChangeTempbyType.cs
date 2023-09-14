using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeTempbyType : MonoBehaviour
{
    public string input;
    public SpriteRenderer spr;
    public ControlCube cube;
    public TMP_InputField inputField;

    // Update is called once per frame
    public void GetTemp(string s)
    {
        input = s;
        //Debug.Log(input);
        ColorChange();

    }
    public void ColorChange ()
    {
        if (input == "Start" || input == "start")
        {
            cube.speed = 2.5f;
            ResetInput();
        }
        else if (input == "Stop" || input == "stop")
        {
            cube.speed = 0;
            ResetInput();
        }
        else if (input == "Faster" || input == "faster")
        {
            cube.modSpeed += 0.5f;
            ResetInput();
        }
        else if (input == "Slower" || input == "slower")
        {
            cube.modSpeed -= 0.5f;
            ResetInput();
        }
    }

    private void ResetInput()
    {
        inputField.text = "";
    }
    public void ReselectInput()
    {
        inputField.ActivateInputField();
    }
}
