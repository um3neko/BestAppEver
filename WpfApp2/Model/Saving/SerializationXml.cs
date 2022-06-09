using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;


namespace WpfApp2.Model.Saving
{
    internal static class SerializationXml 
    {
        //public static void SaveToXml(List<Goal> goals)
        //{
        //    try
        //    {
        //        using (FileStream fs = new FileStream("SAVEDGOALS.xml", FileMode.OpenOrCreate))
        //        {
        //            var xmlSerializer = new XmlSerializer(typeof(List<Goal>));
        //            xmlSerializer.Serialize(fs, goals);
        //        }
        //        MessageBox.Show("SAVED");
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.ToString());
        //    }

        //}
        //public static List<Goal> ReadFromXml()
        //{
        //    List<Goal> goals = new List<Goal>();
        //    try
        //    {
                
        //        using (FileStream fs = new FileStream("SAVEDGOALS.xml", FileMode.Open))
        //        {
        //            var xmlSerializer = new XmlSerializer(typeof(List<Goal>));
        //            goals = xmlSerializer.Deserialize(fs) as List<Goal>;
        //        }
        //        MessageBox.Show("XML OK");
        //        return goals;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.ToString());
        //        return goals;

        //    }
        //}
    }
}
