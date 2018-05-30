using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    internal class Weapon : Item
    {
        public int Accuracy;
        public int AmmoCapacity;
        public int ArmorPen;
        public int DamageValue;
        public string FireMode = "None";
        public bool[] Modslots = {false, false, false, false, false, false};
        public int RecoilCompensation;
        public string SubCategory = "None";

        public Weapon()
        {
            itemType = ItemType.Weapon;
        }

        public override void Save()
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

            objWriter.WriteStartElement("Item");
            objWriter.WriteElementString("Type", "Weapon");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail);
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("DeviceRating", DeviceRating.ToString());
            objWriter.WriteElementString("Weight", Weight.ToString());


            //Write Weapon Info 
            objWriter.WriteElementString("SubCategory", SubCategory);
            objWriter.WriteElementString("Accuracy", Accuracy.ToString());
            objWriter.WriteElementString("DamageValue", DamageValue.ToString());
            objWriter.WriteElementString("ArmorPen", ArmorPen.ToString());
            objWriter.WriteElementString("RecoilCompensation", RecoilCompensation.ToString());
            objWriter.WriteElementString("AmmoCapacity", AmmoCapacity.ToString());
            objWriter.WriteElementString("FireModes", FireMode);

            //Write ModSlots
            objWriter.WriteStartElement("ModSlots");

            objWriter.WriteElementString(Modslots[0] ? "Enabled" : "Disabled", "Stock");
            objWriter.WriteElementString(Modslots[1] ? "Enabled" : "Disabled", "Side");
            objWriter.WriteElementString(Modslots[2] ? "Enabled" : "Disabled", "Barrel");
            objWriter.WriteElementString(Modslots[3] ? "Enabled" : "Disabled", "Top");
            objWriter.WriteElementString(Modslots[4] ? "Enabled" : "Disabled", "Under");
            objWriter.WriteElementString(Modslots[5] ? "Enabled" : "Disabled", "Misc");

            objWriter.WriteEndElement();


            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();
        }

        public override void Load()
        {
            var objXmlDocument = new XmlDocument();
            objXmlDocument.Load(FileName);
            var objXmlItem = objXmlDocument.SelectSingleNode("/Item");

            //Load Universal Item Info
            objXmlItem.ReadString("Name", ref Name);
            objXmlItem.ReadString("Description", ref Description);
            objXmlItem.ReadString("Rules", ref Rules);
            objXmlItem.ReadString("Availability", ref Avail);
            objXmlItem.ReadInt("Cost", ref Cost);
            objXmlItem.ReadInt("DeviceRating", ref DeviceRating);
            objXmlItem.ReadDouble("Weight", ref Weight);

            //Load Weapon Info
            itemType = ItemType.Weapon;
            objXmlItem.ReadString("SubCategory", ref SubCategory);
            objXmlItem.ReadInt("Accuracy", ref Accuracy);
            objXmlItem.ReadInt("DamageValue", ref DamageValue);
            objXmlItem.ReadInt("ArmorPen", ref ArmorPen);
            objXmlItem.ReadInt("RecoilCompensation", ref RecoilCompensation);
            objXmlItem.ReadInt("AmmoCapacity", ref AmmoCapacity);
            objXmlItem.ReadString("FireModes", ref FireMode);

            foreach (XmlElement i in objXmlItem.SelectSingleNode("ModSlots"))
                if (i.OuterXml.Contains("Enabled"))
                {
                    if (i.InnerText.Equals("Stock")) Modslots[0] = true;
                    if (i.InnerText.Equals("Side")) Modslots[1] = true;
                    if (i.InnerText.Equals("Barrel")) Modslots[2] = true;
                    if (i.InnerText.Equals("Top")) Modslots[3] = true;
                    if (i.InnerText.Equals("Under")) Modslots[4] = true;
                    if (i.InnerText.Equals("Misc")) Modslots[5] = true;
                }
        }
    }
}