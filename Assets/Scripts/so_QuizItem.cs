using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class so_QuizItem : ScriptableObject
{
    public string question;
    public Toggle optA, optB, optC;
    public int answer;

}
