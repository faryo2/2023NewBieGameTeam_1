using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SE : MonoBehaviour
{
    public AudioSource soundEffect; // 効果音を再生するためのオーディオソース

    private void Start()
    {
        // ボタンにクリック時の処理を追加
        Button backButton = GetComponent<Button>();
        backButton.onClick.AddListener(PlaySoundAndGoBack);
    }

    // 効果音を再生してシーンを移動する関数
    private void PlaySoundAndGoBack()
    {
        // 効果音再生
        soundEffect.Play();

        // 少し待ってからシーンを移動
        float soundDuration = soundEffect.clip.length;
        Invoke("GoBackToPreviousScene", soundDuration);
    }

    // 前のシーンに移動する関数
    private void GoBackToPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int previousSceneIndex = currentSceneIndex - 1;
        if (previousSceneIndex < 0)
        {
            previousSceneIndex = 0;
        }
        SceneManager.LoadScene(previousSceneIndex);
    }
}
