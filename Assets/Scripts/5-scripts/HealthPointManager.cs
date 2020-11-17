using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
    Class which handles operations on the player's hp
*/
[RequireComponent(typeof(TextMeshPro))]
public class HealthPointManager : MonoBehaviour
{

    [SerializeField] int hp = 3; // default value

    private TextMeshPro hpText;

    void Start()
    {
        hpText = GetComponent<TextMeshPro>();
        hpText.text = hp.ToString();    
    }

    public int getHP()
    {
        return hp;
    }

    public void reduceHP()
    {
        hp--;
        hpText.text = hp.ToString(); 
    }
}
