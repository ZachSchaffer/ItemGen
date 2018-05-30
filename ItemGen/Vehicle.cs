using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    internal class Vehicle : Item
    {
        public int Armor;
        public int Body;
        public int Handling;
        public int Seats;
        public int Speed;
        public int UpCap;

        public Vehicle()
        {
            itemType = ItemType.Vehicle;
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
            objWriter.WriteElementString("Type", "Vehicle");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail);
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("DeviceRating", DeviceRating.ToString());
            objWriter.WriteElementString("Weight", Weight.ToString());


            //Write Vehicle Info 
            objWriter.WriteElementString("Body ", Body.ToString());
            objWriter.WriteElementString("Speed", Speed.ToString());
            objWriter.WriteElementString("Handling", Handling.ToString());
            objWriter.WriteElementString("Armor", Armor.ToString());
            objWriter.WriteElementString("Seats", Seats.ToString());
            objWriter.WriteElementString("UpCap", UpCap.ToString());


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

            //Load Vehicle Info
            itemType = ItemType.Vehicle;
            objXmlItem.ReadInt("Body ", ref Body);
            objXmlItem.ReadInt("Speed", ref Speed);
            objXmlItem.ReadInt("Handling", ref Handling);
            objXmlItem.ReadInt("Armor", ref Armor);
            objXmlItem.ReadInt("Seats", ref Seats);
            objXmlItem.ReadInt("UpCap", ref UpCap);
        }
    }
}