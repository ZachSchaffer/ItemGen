using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    internal class Drone : Item
    {
        public int Firewall = 0;
        public int DroneLimit = 0;

        public Drone()
        {
            this.itemType = ItemType.DroneMaster;
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

            objWriter.WriteStartElement("Item");
            objWriter.WriteElementString("Type", "Drone");

            //Write Universal Item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail.ToString());
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("DeviceRating", DeviceRating.ToString());
            objWriter.WriteElementString("Weight", Weight.ToString());


            //Write Drone Info 
            objWriter.WriteElementString("Firewall", Firewall.ToString());
            objWriter.WriteElementString("DroneLimit", DroneLimit.ToString());

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
            //Load Cyberdeck Info
            this.itemType = ItemType.DroneMaster;
            objXmlItem.ReadInt("Firewall", ref Firewall);
            objXmlItem.ReadInt("DroneLimit",ref  DroneLimit);
                 


        }
    }
}
