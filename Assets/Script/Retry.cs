using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // 前のシーンに戻るための関数
    public void GoBackToPreviousScene()
    {
        // 現在のシーンのインデックスを取得
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 前のシーンのインデックスを計算
        int previousSceneIndex = currentSceneIndex - 1;

        // インデックスが0未満にならないように調整
        if (previousSceneIndex < 0)
        {
            previousSceneIndex = 0;
        }

        // 前のシーンに移動
        SceneManager.LoadScene(previousSceneIndex);
    }
}
