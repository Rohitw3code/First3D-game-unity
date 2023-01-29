using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Scoreupdate : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score_;

    void Update() {

        score_.text = "Score : "+player.position.z.ToString("0");
        
    }
}
