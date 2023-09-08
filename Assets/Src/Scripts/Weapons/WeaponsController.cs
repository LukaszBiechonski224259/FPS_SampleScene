using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
    [Header("References")] 
    public Camera rayCam;
    public ParticleSystem gunFlash;
    private AudioSource source;
    
    [Header("Statistics")] 
    public int damage;
    public int magazineSize;
    public int bulletsFiredWithEachTap;
    
    public float fireRate;
    public float spread;
    public float range;
    public float reloadTime;
    public float timeBetweenShots;

    public String effectiveAgainst;

    public bool continousFire;

    private int bulletsLeft;
    private int bulletsShot;
    private int totalAmmoCount;

    private bool shooting;
    private bool readyToShoot;
    private bool reloading;
    private bool allowButtonHold;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Reload()
    {
        
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void Shoot()
    {

        source.Play();
        RaycastHit hit;
        if (Physics.Raycast(rayCam.transform.position, rayCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.GetComponent<Interactable>() != null)
            {
                Debug.Log(hit.transform.GetComponent<Interactable>().material);
                if (hit.transform.GetComponent<Interactable>().material == effectiveAgainst)
                {
                    hit.transform.GetComponent<Interactable>().TakeDamage(damage);
                    Debug.Log(hit.transform.GetComponent<Interactable>().durability);
                }
            }

            // if (rayHit.collider.CompareTag("Enemy"))
                //rayHit.collider.GetComponent<ShootingAi>().TakeDamage(damage);
        }

        bulletsLeft--;
        //Invoke("ResetShot", timeBetweenShots);

        void ResetShot()
        {
            
        }
    }
}
