using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountScript : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI tmPro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmPro.text = player.position.z.ToString("0");
    }
}
