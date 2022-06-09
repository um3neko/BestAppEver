using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using WpfApp2.Model;

namespace WpfApp2.Data.GoalsCollection
{
    [Serializable]
    public class GoalData : AbstractGoal
    {
        public static void SaveToXml()
        {
            try
            {
                using (FileStream fs = new FileStream("SAVEDGOALS.xml", FileMode.OpenOrCreate))
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Goal>));
                    
                    xmlSerializer.Serialize(fs, GoalsSingletonCollection);
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

        }

        public static void ReadFromXml()
        {
            try
            {
                
                using (FileStream fs = new FileStream("SAVEDGOALS.xml", FileMode.Open))
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Goal>));
                    GoalsSingletonCollection = xmlSerializer.Deserialize(fs) as List<Goal>;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("New");
                GoalsSingletonCollection = new List<Goal>();

            }
        }

        public static List<Goal> GoalsSingletonCollection { get; set; }

        public static void Add(Goal goal)
        {
            GoalsSingletonCollection.Add(goal);
        }
        public static void Delete(Goal goal)
        {
            throw new NotImplementedException();
        }



    }
}
