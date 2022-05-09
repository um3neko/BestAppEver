using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace WpfApp2.Model.Saving
{
    internal static class SerializationXml
    {
        private static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Goal>));
       
        public static void SaveToXml(List<Goal> goals)
        {
            
            try
            {
                using (FileStream fs = new FileStream("SAVEDGOALS.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, goals);
                    
                }

                MessageBox.Show("SAVED");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                
            }
            
        }

        public static List<Goal> ReadFromXml()
        {
            try
            {
                List<Goal> goals;
                using (FileStream fs = new FileStream("SAVEDGOALS.xml", FileMode.OpenOrCreate))
                {
                    goals = xmlSerializer.Deserialize(fs) as List<Goal>;
                }

                MessageBox.Show("XML OK");
                return goals;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
