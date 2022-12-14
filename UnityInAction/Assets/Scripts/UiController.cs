using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private int _score;

    private void Awake()
    {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    void Start()
    {
        _score = 0;
        scoreLabel.text = _score.ToString();

        settingsPopup.Close();
    }

    public void OnOpneSettings()
    {
        settingsPopup.Open();
    }

    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }

    private void OnDestroy()
    {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnEnemyHit()
    {
        _score += 1;
        scoreLabel.text = _score.ToString();

    }
}
