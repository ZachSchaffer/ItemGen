using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    public class Armor : Item
    {
        public int ArmorRating;
        public int Capacity;
        public string SubCategory = "None";

        public Armor()
        {
            itemType = ItemType.Armor;
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
            objWriter.WriteElementString("Type", "Armor");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail);
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("DeviceRating", DeviceRating.ToString());
            objWriter.WriteElementString("Weight", Weight.ToString());

            //Write Armor Info
            objWriter.WriteElementString("ArmorRating", ArmorRating.ToString());
            objWriter.WriteElementString("Capacity", Capacity.ToString());
            objWriter.WriteElementString("Subcategory", SubCategory);


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
            objXmlItem.ReadInt("Weight", ref Weight);

            //Load Armor Info
            this.itemType = ItemType.Armor;
            objXmlItem.ReadInt("ArmorRating", ref ArmorRating);
            objXmlItem.ReadInt("Capacity", ref Capacity);
            objXmlItem.ReadString("Subcategory", ref SubCategory);


        }
    }
}