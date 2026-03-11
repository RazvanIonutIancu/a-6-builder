using Godot;
using System;

public partial class UiRoot : Control
{

    private string[] prefixes = ["Old", "Great", "Broken", "Magic", "Cursed", "Blessed", "Damaged"];
    private string[] types = ["sword", "axe", "mace", "wand", "staff", "dagger"];
    private string[] suffixes = ["of Ancients", "of Burning Embers", "of the Wise", "of Dragons", "of Calamity"];



    public void OnButtonClick()
    {

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

    public string BuildItem()
    {
        return item.GetName();
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
