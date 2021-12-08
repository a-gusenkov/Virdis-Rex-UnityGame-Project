using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
  [SerializeField] Slider volumeSlider;

  void Start()
  {
    if (!PlayerPrefs.HasKey("volume"))
    {
      PlayerPrefs.SetFloat("volume", 1);
    }
    else
    {
      Load();
    }
  }

  public void changeVolume()
  {
    AudioListener.volume = volumeSlider.value;
    Save();
  }
  private void Load()
  {
    volumeSlider.value = PlayerPrefs.GetFloat("volume");
  }
  private void Save()
  {
    PlayerPrefs.SetFloat("volume", volumeSlider.value);
  }
}
