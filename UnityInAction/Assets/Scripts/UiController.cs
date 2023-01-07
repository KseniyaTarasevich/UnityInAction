using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    void Start()
    {
        settingsPopup.Close();
    }

    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpneSettings()
    {
        settingsPopup.Open();
    }

    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }
}
