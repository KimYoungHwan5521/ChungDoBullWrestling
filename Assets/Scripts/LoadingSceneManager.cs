using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneManager : MonoBehaviour
{
    public static string nextScene;
    [SerializeField] Image ProgressBar;
    public Text ProgressText;

    void Start()
    {
        StartCoroutine(LoadScene());        
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }

    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        float timer = 0.0f;
        while(!op.isDone)
        {
            yield return null;
            timer += Time.deltaTime;
            if(op.progress < 0.9f)
            {
                ProgressBar.fillAmount = Mathf.Lerp(ProgressBar.fillAmount, op.progress, timer);
                ProgressText.text = ProgressBar.fillAmount.ToString() + " %";
                if(ProgressBar.fillAmount >= op.progress)
                {
                    timer = 0f;
                }
            }
            else
            {
                ProgressBar.fillAmount = Mathf.Lerp(ProgressBar.fillAmount, 1f, timer);
                ProgressText.text = ProgressBar.fillAmount.ToString() + " %";
                if(ProgressBar.fillAmount == 1.0f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
