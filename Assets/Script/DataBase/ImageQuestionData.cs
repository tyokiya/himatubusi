using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "QuestionDataBase", menuName = "画像問題データ作成")]

public class ImageQuestionData : ScriptableObject
{
    [SerializeField] public Image image;
    [SerializeField] public string questionText;
    [SerializeField] public string choices1;
    [SerializeField] public string choices2;
    [SerializeField] public string choices3;
    [SerializeField] public string choices4;
    [SerializeField] public int anserNum;
    [SerializeField] public string message;
}
