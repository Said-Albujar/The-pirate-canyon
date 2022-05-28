using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text AmmoText;

    public static GameManager Instance { get; private set; }

    public int cañonAmmo = 1;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        AmmoText.text = cañonAmmo.ToString();
    }

}
