using UnityEngine;

public class FoodAnimationManager : MonoBehaviour
{
    public Animator bananaAnimator;     // バナナ用
    public Animator riceballAnimator;    // おにぎり用
    public Animator sandwichAnimator;   // サンドイッチ用

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
            bananaAnimator.SetTrigger("Play");
            isReadyToPlay = false;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            riceballAnimator.SetTrigger("Play");
            isReadyToPlay = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            sandwichAnimator.SetTrigger("Play");
            isReadyToPlay = false;
        }
    }
}