using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    public int stamina;
    public int maxStamina = 100;

    void Start()
    {
        stamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(stamina <= maxStamina) stamina += 1;
    }
}
