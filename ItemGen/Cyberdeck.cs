using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ItemGen
{
    internal class Cyberdeck : Item
    {
        public int Firewall = 0;
        public int ProgramLimit = 0;

        public Cyberdeck()
        {
            this.itemType = ItemType.Cyberdeck;
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
            objWriter.WriteElementString("Type", "CyberDeck");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail.ToString());
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("DeviceRating", DeviceRating.ToString());
            objWriter.WriteElementString("Weight", Weight.ToString());


            //Write Cyberdeck Info 
            objWriter.WriteElementString("Firewall", Firewall.ToString());
            objWriter.WriteElementString("ProgramLimit", ProgramLimit.ToString());

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
            this.itemType = ItemType.Cyberdeck;
            objXmlItem.ReadInt("Firewall", ref Firewall);
            objXmlItem.ReadInt("ProgramLimit", ref ProgramLimit);


        }

    }
}
