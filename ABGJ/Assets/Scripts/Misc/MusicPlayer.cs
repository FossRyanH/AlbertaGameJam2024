using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : Singleton<MusicPlayer>
{
    [SerializeField] private LevelMusic[] bgmToPlay;
    protected override void Initialize()
    {
        AudioManager.Instance.PlayMusic(bgmToPlay[0].BGM, true, this.gameObject);
    }
}
