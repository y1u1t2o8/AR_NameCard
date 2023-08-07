using UnityEngine;

public class MyARObjectScript : MonoBehaviour
{
    public void DoInteraction()
    {
        // ここに当たり判定が成功した時に実行したい処理を記述します。
        // 例：ARオブジェクトの表示/非表示切り替え、アニメーションの再生など
        gameObject.SetActive(false);
    }
}
