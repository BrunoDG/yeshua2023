using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;


[CreateAssetMenu(fileName = "QuizItemScriptableObject", menuName = "ScriptableObjects/QuizItem")]
public class so_QuizItem : ScriptableObject
{
    public string question;
    public Toggle optA, optB, optC;
    public string answerA, answerB, answerC;
    public int answer;

}
