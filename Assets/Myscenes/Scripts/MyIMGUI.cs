using UnityEngine;
using System.Collections;
using UnityEditor;

public class MyIMGUI : MonoBehaviour
{
    // Переменные хранения текста полей
    private string[] textMass = { "100 HP", "Hello World" };
    private float sliderValue;

    // Значения горизонтального и вертикаольного слайдеров


    void OnGUI()
    {
               
        textMass[0] = GUI.TextField(new Rect(25, 20, 50, 20), textMass[0]);
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300));

        GUILayout.BeginHorizontal();  // Начало строчного заполнения

        GUILayout.BeginVertical();  // Начало столбцового заполнения

        if (GUILayout.RepeatButton("Min"))
            sliderValue = 0.0f;
        if (GUILayout.RepeatButton("Max"))
            sliderValue = 10.0f;


        GUILayout.EndVertical();  // Конец столбцового заполнения

        GUILayout.BeginVertical();  // Начало столбцового заполнения
        GUILayout.Label("Some slider: ");
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 10.0f);
        GUILayout.EndVertical();  // Конец столбцового заполнения

        GUILayout.EndHorizontal();  // Конец строчного заполнения
        GUILayout.EndArea();
    }

  
}













