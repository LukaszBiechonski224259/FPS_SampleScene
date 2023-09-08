using System;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{

    private int selectedWeapon = 0;

    private float input;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= transform.childCount)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }
        
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
                selectedWeapon = transform.childCount;
            else
                selectedWeapon--;
        }
        SelectWeapon();
    }
    
    private void SelectWeapon()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == selectedWeapon)
                transform.GetChild(i).gameObject.SetActive(true);
            else
                transform.GetChild(i).gameObject.SetActive(false);
            
        }
    }
}
