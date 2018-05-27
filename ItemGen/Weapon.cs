using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace ItemGen
{
    internal class Weapon : Item
    {
        public String SubCategory = "UNINITIALIZED";
        public int Accuracy = 0;
        public int DamageValue = 0;
        public int ArmorPen = 0;
        public string FireMode = "UNINITIALIZED";
        public int RecoilCompensation = 0;
        public int AmmoCapacity = 0;
        public List<string> ModSlots = new List<string>();

        public Weapon()
        {
            this.itemType = ItemType.Weapon;
        }

        public override void Save()
        {
            FileStream objStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter objWriter = new XmlTextWriter(objStream, Encoding.UTF8)
            {
                Formatting = Formatting.Indented,
                Indentation = 1,
                IndentChar = '\t'
            };

            //Start Doc
            objWriter.WriteStartDocument();

            objWriter.WriteStartElement("item");
            objWriter.WriteStartElement("Weapon");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail.ToString());
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("Device Rating", DeviceRating.ToString());
            objWriter.WriteElementString("Wegiht", Weight.ToString());

    
            //Write Weapon Info TODO
            objWriter.WriteElementString("SubCategory", SubCategory);
            objWriter.WriteElementString("Accuracy", Accuracy.ToString());
            objWriter.WriteElementString("DamageValue", DamageValue.ToString());
            objWriter.WriteElementString("ArmorPen", ArmorPen.ToString());
            objWriter.WriteElementString("RecoilCompensation", RecoilCompensation.ToString());
            objWriter.WriteElementString("AmmoCapacity", AmmoCapacity.ToString());
            objWriter.WriteElementString("FireModes", FireMode);

            //Write ModSlots
            objWriter.WriteStartElement("ModSlots");

            foreach (String s in ModSlots)
                objWriter.WriteElementString("Mod Slot", s);

            objWriter.WriteEndElement();


            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();

        }
    }
}
