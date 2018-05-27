using System;
using System.IO;
using System.Text;
using System.Xml;

public class Item
{
    public enum ItemType
    {
        Armor,
        Weapon,
        Equipment,
        Ammunition,
        Cyberware,
        Bioware,
        Vehicle,
        Cyberdeck,
        DroneMaster,
        Explosives,
        Misc
    }

    public string FileName = string.Empty;

    public ItemType itemType;

    public Item(ItemType itemType)
    {
        this.itemType = itemType;
    }

    public Item()
    {
    }

    public Array GetTypes() //Return an Array of all possible types from the enum itemType
    {
        var values = Enum.GetValues(typeof(ItemType));
        return values;
    }

    public virtual void Save()
    {
        var objStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        var objWriter = new XmlTextWriter(objStream, Encoding.UTF8)
        {
            Formatting = Formatting.Indented,
            Indentation = 1,
            IndentChar = '\t'
        };

        //Start Doc
        objWriter.WriteStartDocument();

        objWriter.WriteStartElement("item");

        //Write Universal item Info

        objWriter.WriteElementString("Name", Name);
        objWriter.WriteElementString("Description", Description);
        objWriter.WriteElementString("Rules", Rules);
        //objWriter.WriteElementString("Picture", picture); TODO: Picture
        objWriter.WriteElementString("Availability", Avail.ToString());
        objWriter.WriteElementString("Cost", Cost.ToString());
        objWriter.WriteElementString("Device Rating", DeviceRating.ToString());
        objWriter.WriteElementString("Wegiht", Weight.ToString());


        //End Doc
        objWriter.WriteEndElement();
        objWriter.WriteEndDocument();
        objWriter.Close();
        objStream.Close();
    }

    #region item Properties

    public string Name;
    public string Description = "UNINITIALIZED";

    public string Rules = "UNINITIALIZED";

    //TODO: Picture link
    public int Avail = 0;

    public int Cost = 0;
    public int DeviceRating = 0;
    public int Weight = 0;

    #endregion

    /* public void Load() //TODO
    {
        int counter = 0;

        XmlDocument objXmlDocument = new XmlDocument();
        objXmlDocument.Load(FileName);
        XmlNode objXmlCharacter = objXmlDocument.SelectSingleNode("/Player");

        //Load Player Info
        objXmlCharacter.ReadString("Name", ref _Name);
        objXmlCharacter.ReadString("Gender", ref _Gender);
        objXmlCharacter.ReadString("Race", ref _Race);
        objXmlCharacter.ReadInt("Karma", ref _Karma);
        objXmlCharacter.ReadString("CurrencyType", ref _CurrencyName);
        objXmlCharacter.ReadInt("Currency", ref _Currency);
        objXmlCharacter.ReadInt("Level", ref _Level);
        objXmlCharacter.ReadInt("XP", ref _XP);
        objXmlCharacter.ReadInt("HP", ref _HP);
        objXmlCharacter.ReadInt("MaxHP", ref _MaxHP);
        objXmlCharacter.ReadInt("AP", ref _AP);
        objXmlCharacter.ReadInt("CarryWeight", ref _Carry_Weight);
        objXmlCharacter.ReadInt("SpecialPoints", ref _SpecialPoints);
        objXmlCharacter.ReadInt("SkillPoints", ref _Skill_Points);
        objXmlCharacter.ReadInt("SkillPointsOnLevel", ref _Skill_Points_On_Level);
        objXmlCharacter.ReadBool("Addicted", ref _Addicted);
        objXmlCharacter.ReadString("AddictedSubstance", ref _AddictedSubstance);

        //Load Special
        objXmlCharacter.ReadInt("Str", ref _Str);
        objXmlCharacter.ReadInt("Per", ref _Per);
        objXmlCharacter.ReadInt("End", ref _End);
        objXmlCharacter.ReadInt("Cha", ref _Cha);
        objXmlCharacter.ReadInt("Int", ref _Int);
        objXmlCharacter.ReadInt("Agi", ref _Agi);
        objXmlCharacter.ReadInt("Luc", ref _Luc);

        //Load Skills
        objXmlCharacter.ReadInt("Barter", ref _Barter);
        objXmlCharacter.ReadInt("EnergyWeapons", ref _Energy_Weapons);
        objXmlCharacter.ReadInt("Explosives", ref _Explosives);
        objXmlCharacter.ReadInt("Guns", ref _Guns);
        objXmlCharacter.ReadInt("Lockpick", ref _Lockpick);
        objXmlCharacter.ReadInt("Medicine", ref _Medicine);
        objXmlCharacter.ReadInt("MeleeWeapons", ref _Melee_Weapons);
        objXmlCharacter.ReadInt("Repair", ref _Repair);
        objXmlCharacter.ReadInt("Science", ref _Science);
        objXmlCharacter.ReadInt("Sneak", ref _Sneak);
        objXmlCharacter.ReadInt("Speech", ref _Speech);
        objXmlCharacter.ReadInt("Survival", ref _Survival);
        objXmlCharacter.ReadInt("Unarmed", ref _Unarmed);

        //Load Other
        objXmlCharacter.ReadBool("Created", ref _Created);


        //Load Perks
        foreach (XmlElement i in objXmlCharacter.SelectSingleNode("Perks"))
        {
            counter = 0;
            foreach (Perk j in Perklist)
            {
                if (j.GetName().Equals(i.InnerText))
                    AddPerk(counter);

                counter++;
            }

        }

        foreach (XmlElement i in objXmlCharacter.SelectSingleNode("AppliedPerks"))
        {
            counter = 0;
            foreach (Perk j in Perklist)
            {
                if (j.GetName().Equals(i.InnerText))
                    AddAppliedPerk(counter);

                counter++;
            }

        }

        //Add options to be loaded

    }*/
}