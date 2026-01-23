using UnityEngine;

public class Player : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isFirstSelect = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 获取当前物体上的 AudioSource 组件
        audioSource = GetComponent<AudioSource>();
        
        if (audioSource == null)
        {
            Debug.LogWarning("未找到 AudioSource 组件！");
        }
    }

    // 当物体被选择时调用此方法
    public void OnSelect()
    {
        if (audioSource == null) return;

        if (isFirstSelect)
        {
            // 第一次选择，播放音频
            audioSource.Play();
            isFirstSelect = false;
        }
        else
        {
            // 之后的选择，切换播放/暂停状态
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.UnPause();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
