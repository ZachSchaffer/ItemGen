using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
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
            objWriter.WriteElementString("Availability", Avail);
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("DeviceRating", DeviceRating.ToString());
            objWriter.WriteElementString("Weight", Weight.ToString());


            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();
        }


        public virtual void Load()
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
            objXmlItem.ReadInt("Weight", ref Weight);
        }

        #region item Properties

        public string Name = "None";
        public string Description = "None";

        public string Rules = "None";

        //TODO: Picture link
        public string Avail = "None";

        public int Cost;
        public int DeviceRating;
        public int Weight;

        #endregion
    }
}