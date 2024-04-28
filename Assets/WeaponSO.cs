using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "weaponData")]
public class WeaponSO : ScriptableObject {

    public enum Types {
        none,
        silent,
        singleUse,
        crazyOne
    }

    [field: SerializeField] public string weaponName { get; private set; }
    [field: SerializeField] public Sprite sprite { get; private set; }
    [field: SerializeField] public int standardDmg { get; private set; }
    [field: SerializeField] public int criticalDmg { get; private set; }
    [field: SerializeField] public Types type { get; private set; }

    public string GetTypeString() {
        string str;
        switch(type) {
            case Types.silent:
                str = "silent";
                break;
            case Types.singleUse:
                str = "single-use";
                break;
            case Types.crazyOne:
                str = "bum-bum";
                break;
            default:
                str = "";
                break;

        }
        return str;
    }
}