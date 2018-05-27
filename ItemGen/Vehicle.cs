using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    internal class Vehicle : Item
    {
        public int Body = 0;
        public int Speed = 0;
        public int Handling = 0;
        public int Armor = 0;
        public int Seats = 0;
        public int UpCap = 0;

        public Vehicle()
        {
            this.itemType = ItemType.Vehicle;
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
            objWriter.WriteStartElement("Vehicle");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail.ToString());
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("Device Rating", DeviceRating.ToString());
            objWriter.WriteElementString("Wegiht", Weight.ToString());


            //Write Vehicle Info 
            objWriter.WriteElementString("Body ", Body.ToString());
            objWriter.WriteElementString("Speed", Speed.ToString());
            objWriter.WriteElementString("Handling", Handling.ToString());
            objWriter.WriteElementString("Armor", Armor.ToString());
            objWriter.WriteElementString("Seats", Seats.ToString());
            objWriter.WriteElementString("UpCap", UpCap.ToString());


            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();

        }

    }
}
