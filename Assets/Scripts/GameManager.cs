using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string gameState;

    public static int totalScore;//�Q�[���S�ʂ�ʂ��ẴX�R�A
    public static int stageScore;//���̃X�e�[�W�Ɋl�������X�R�A

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //�Q�[���̏�����Ԃ�playing
        gameState = "playing";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameState);
    }
}