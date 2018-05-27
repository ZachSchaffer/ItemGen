using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    internal class Cyberware : Item
    {
        public string Grade = "UNINITIALIZED";
        public int Agility = 0;
        public int Strength = 0;
        public int Capacity = 0;
        public string Category = "UNINITIALIZED";

        public Cyberware()
        {
            this.itemType = ItemType.Cyberware;
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
            objWriter.WriteStartElement("Cyberware");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail.ToString());
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("Device Rating", DeviceRating.ToString());
            objWriter.WriteElementString("Wegiht", Weight.ToString());


            //Write Cyberware Info 
            objWriter.WriteElementString("Grade", Grade);
            objWriter.WriteElementString("Agility", Agility.ToString());
            objWriter.WriteElementString("Strength", Strength.ToString());
            objWriter.WriteElementString("Capacity", Capacity.ToString());
            objWriter.WriteElementString("Category", Category);

            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();

        }
    }
}
