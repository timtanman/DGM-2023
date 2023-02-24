using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsDisplayed : MonoBehaviour
{

    public PlayerStats playerstats;

    public Text nameText;
    public Text guntypeText;
    public Text healthText;
    public Text GunPowerText;
    public Text firerateText;

    void Start()
    {
        Debug.Log(playerstats.name);
        Debug.Log(playerstats.guntype);
        Debug.Log(playerstats.health);
        Debug.Log(playerstats.GunPower);

        nameText.text = playerstats.name;
        guntypeText.text = playerstats.guntype.ToString();
        healthText.text = playerstats.health.ToString();
        GunPowerText.text = playerstats.GunPower.ToString();
        firerateText.text = playerstats.firerate.ToString();
    }

}
