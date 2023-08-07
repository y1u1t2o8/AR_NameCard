using UnityEngine;

public class ARObjectInteraction : MonoBehaviour
{
    public LayerMask interactionLayerMask; // Rayの当たり判定を行う対象レイヤーマスク

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                // タップされたスクリーン座標をRayに変換
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Rayが当たったオブジェクトを検出
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, interactionLayerMask))
                {
                    // 当たったオブジェクトに対して適切な処理を行う
                    GameObject interactedObject = hit.collider.gameObject;
                    // アニメーション再生の処理を実行
                    PlayAnimationOnInteract(interactedObject);
                }
            }
        }
    }

    void PlayAnimationOnInteract(GameObject obj)
    {
        // ARオブジェクトにアタッチされているAnimatorコンポーネントを取得
        Animator animator = obj.GetComponent<Animator>();
        if (animator != null)
        {
            // アニメーションを再生（Animator Controller内で定義したアニメーションステート名を指定）
            animator.Play("YourAnimationStateName");
        }
    }
}
