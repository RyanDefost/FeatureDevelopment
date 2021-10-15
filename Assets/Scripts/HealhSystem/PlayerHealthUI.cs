using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Text _text;
    private PlayerHealthComponent _playerHealthComponent;    

    public void UpdateUI(float NumbOfLives)
    {
        _text.text = "PlayerHealth: " + NumbOfLives;
    }
}
