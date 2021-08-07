using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class LootDrop : MonoBehaviour
    {
        [System.Serializable]
    public class DropWeapon{
        public string Name;
        public GameObject WeaponDropped;
        public int ItemWeight;
    }
    public List<DropWeapon> Loot = new List<DropWeapon>();

    private void Start() {
        SortLootTableByWeight();
    }

    // change string to an item class
    // string is only for debug
    public GameObject CalculateLoot(){
        int TotalWeight = 0;
        

        foreach (var item in Loot)
        {
            TotalWeight += item.ItemWeight;
        }

        int roll = Random.Range(0, TotalWeight+1);
        

        foreach (var weight in Loot)
        {
            if(roll <= weight.ItemWeight){
                print(weight.Name + " has dropped!");
                return weight.WeaponDropped;
            }else{
                roll -= weight.ItemWeight;
            }
        }
        return null;
    }

    private void SortLootTableByWeight(){
        Loot.Sort(CompareTwoLootItemsByWeight);
        Loot.Reverse();
    }

    static int CompareTwoLootItemsByWeight(DropWeapon a, DropWeapon b){
        return a.ItemWeight.CompareTo(b.ItemWeight);
    }
    }
}
