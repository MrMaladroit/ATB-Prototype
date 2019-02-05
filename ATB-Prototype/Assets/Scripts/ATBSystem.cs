using UnityEngine;
using UnityEngine.UI;

public class ATBSystem : MonoBehaviour
{
    [SerializeField] private GameObject characterActionsMenu;
    [SerializeField] private Character character;
    private Slider slider;
    private bool isCharacterReady = false;
    private int fillSpeed;
    private int baseFillSpeed = 5;

    public void ActionPerformed()
    {
        isCharacterReady = false;
        characterActionsMenu.SetActive(false);
        slider.value = 0;
    }
    private void Awake()
    {
        SetFillSpeed();
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if(isCharacterReady == false)
        {
            FillGauge();
        }
        
        if(slider.value >= slider.maxValue)
        {
            characterActionsMenu.SetActive(true);
            isCharacterReady = true;
        }
    }
    private void SetFillSpeed()
    {
        fillSpeed = character.SpeedStat + baseFillSpeed;
    }
    
    private void FillGauge()
    {
        slider.value += fillSpeed * Time.deltaTime;
    }
}