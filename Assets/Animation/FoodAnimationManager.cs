using UnityEngine;

public class FoodAnimationManager : MonoBehaviour
{
    public Animator[] bananaAnimators;     // バナナ用のAnimator配列
    public Animator[] riceballAnimators;   // おにぎり用のAnimator配列
    public Animator[] sandwichAnimators;   // サンドイッチ用のAnimator配列

    public Animator[] bananaExplainAnimators;     // バナナ豆知識説明用のAnimator配列
    public Animator[] riceballExplainAnimators;   //  おにぎり豆知識説明用のAnimator配列
    public Animator[] sandwichExplainAnimators;   //  サンドイッチ豆知識説明用のAnimator配列


    private bool isReadyToPlay = false;

    void Start()
    {
        isReadyToPlay = true; 
        Debug.Log("キー入力待ち状態です。");
    }

    void Update()
    {
        if (!isReadyToPlay) return;

        if (Input.GetKeyDown(KeyCode.B))
        {
            PlayAnimation(bananaAnimators);
            isReadyToPlay = false;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            PlayAnimation(riceballAnimators); 
            isReadyToPlay = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlayAnimation(sandwichAnimators);
            isReadyToPlay = false;
        }
    }

    private void PlayAnimation(Animator[] animators)
    {
        foreach (Animator anim in animators)
        {
            anim.SetTrigger("Play"); // Animatorに「Play」トリガーを送る
        }
    }
}