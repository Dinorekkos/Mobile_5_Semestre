using Dino.Utility.Audio;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
using Dino.Utility.Audio;

public class SettingsUI : UIWindow
{
   [Header("SettingsUI")]
   [SerializeField] private Slider _volumeSFXSlider;
   [SerializeField] private Slider _volumeMusicSlider;


   public override void Initialize()
   {
      base.Initialize();
      //Cuando cambia el valor del slider, se llama al método OnVolumeChanged
      _volumeSFXSlider.onValueChanged.AddListener(OnVolumeSFXChanged);
      _volumeMusicSlider.onValueChanged.AddListener(OnVolumeMusicChanged);
      
   }

   private void OnVolumeMusicChanged(float volume)
   {
      Debug.Log($"Volume changed to: {volume}");
      AudioManager.Instance.UpdateAudioMixerGroupVolume(volume,Dino.Utility.Audio.AudioType.Music);
   }

   private void OnVolumeSFXChanged(float volume)
   {
      Debug.Log($"Volume changed to: {volume}");
      AudioManager.Instance.UpdateAudioMixerGroupVolume(volume,Dino.Utility.Audio.AudioType.SFX);
   }
   
   

   [Button("Test Show")]
   private void TestShow()
   {
      Show();
   }
    
   [Button("Test Hide")]
   private void TestHide()
   {
      Hide();
   }


}
