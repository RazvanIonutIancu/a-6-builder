using Godot;
using System;
using System.Linq;

public partial class UiRoot : Control
{

    private string[] prefixes = ["Old", "Great", "Broken", "Magic", "Cursed", "Blessed", "Damaged"];
    private string[] types = ["Sword", "Axe", "Mace", "Wand", "Staff", "Dagger"];
    private string[] suffixes = ["of Ancients", "of Burning Embers", "of the Wise", "of Dragons", "of Calamity"];



    public void OnButtonClick()
    {
        Random random = new Random();

        string newPrefix = prefixes[random.Next(0, prefixes.Count())];
        string newType = types[random.Next(0, types.Count())];
        string newSuffix = suffixes[random.Next(0, suffixes.Count())];

        Item newItem = new Builder().SetPrefix(newPrefix).SetType(newType).SetSuffix(newSuffix).BuildItem();

        GetNode<Label>("/root/UiRoot/Label").Text = "Chest Content: " + newItem.GetName();
    }




}




public class Builder
{
    private Item item = new Item();


    public Builder SetPrefix(string newPrefix)
    {
        item.prefix = newPrefix;
        return this;
    }

    public Builder SetType(string newType)
    {
        item.type = newType;
        return this;
    }

    public Builder SetSuffix(string newSuffix)
    {
        item.suffix = newSuffix;
        return this;
    }

    public Item BuildItem()
    {
        return item;
    }

}

public class Item
{

    public string prefix { get; set; }
    public string type { get; set; }
    public string suffix { get; set; }


    public string GetName()
    {
        string name = "";

        if(!string.IsNullOrEmpty(prefix))
        {
            name += prefix + " ";
        }
        if(!string.IsNullOrEmpty(type))
        {
            name += type;
        }
        if(!string.IsNullOrEmpty(suffix))
        {
            name += " " + suffix;
        }

        return name;

    }
}
