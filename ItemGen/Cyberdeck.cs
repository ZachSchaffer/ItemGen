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

            objWriter.WriteStartElement("item");
            objWriter.WriteStartElement("Cyberdeck");

            //Write Universal item Info

            objWriter.WriteElementString("Name", Name);
            objWriter.WriteElementString("Description", Description);
            objWriter.WriteElementString("Rules", Rules);
            //objWriter.WriteElementString("Picture", picture); TODO: Picture
            objWriter.WriteElementString("Availability", Avail.ToString());
            objWriter.WriteElementString("Cost", Cost.ToString());
            objWriter.WriteElementString("Device Rating", DeviceRating.ToString());
            objWriter.WriteElementString("Wegiht", Weight.ToString());


            //Write Cyberdeck Info 
            objWriter.WriteElementString("Firewall", Firewall.ToString());
            objWriter.WriteElementString("ProgramLimit", ProgramLimit.ToString());

            //End Doc
            objWriter.WriteEndElement();
            objWriter.WriteEndElement();
            objWriter.WriteEndDocument();
            objWriter.Close();
            objStream.Close();

        }

    }
}
