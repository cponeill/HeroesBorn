using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurves : MonoBehaviour
{
    public Character hero = new Character();
    public Character heroine = new Character("Agatha");
    public Weapon huntingBow = new Weapon("Hunting Bow", 105);

    public Transform camTransform;

    public GameObject directionLight;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        CreateKnight();
        CreateWarBow();

        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateKnight()
    {
        Paladin Knight = new Paladin("The Knight", huntingBow);
        Knight.PrintStatsInfo();
    }

    void CreateWarBow()
    {
        Weapon warBow = huntingBow;
        warBow.name = "WarBow";
        warBow.damage = 155;
        warBow.PrintWeaponInfo();
    }
}
