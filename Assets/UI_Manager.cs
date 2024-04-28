using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_Manager : MonoBehaviour {

    [SerializeField] UIDocument uiRef;
    [SerializeField] WeaponSO mainWeapon, secWeapon;
    VisualElement ui;
    VisualElement weaponImage, secondWeaponImage;
    TextElement weaponName, type, damageAmount, criticalAmount;

    void Start() {
        SetRefs();
        SetMainWeapon();
        SetSecWeapon();
    }

    void SetRefs() {
        ui = uiRef.rootVisualElement;
        weaponName = ui.Q<Label>("weaponName");
        weaponImage = ui.Q("weaponImage");
        type = ui.Q<Label>("type");
        damageAmount = ui.Q<Label>("damageAmount");
        criticalAmount = ui.Q<Label>("criticalAmount");
        secondWeaponImage = ui.Q("secondWeaponImage");
    }

    void SetMainWeapon() {
        weaponName.text = mainWeapon.weaponName.ToUpper();
        weaponImage.style.backgroundImage = new StyleBackground(mainWeapon.sprite);
        type.text = mainWeapon.GetTypeString().ToUpper();
        damageAmount.text = mainWeapon.standardDmg.ToString();
        criticalAmount.text = mainWeapon.criticalDmg.ToString();

    }

    void SetSecWeapon() {
        secondWeaponImage.style.backgroundImage = new StyleBackground(secWeapon.sprite);
    }
}