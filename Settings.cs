using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Escape
{
    public class MySettings
    {
        [XmlElement("Num")]
        public int MyNumber { get; set; }

        

        public void Save()
        {
            using (Stream stream = File.Create(SettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(this.GetType());
                ser.Serialize(stream, this);
            }
        }

        public static MySettings Load()
        {
            if (!File.Exists(SettingsFile))
                return DefaultSettings;

            using (Stream stream = File.OpenRead(SettingsFile))
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))

            {
                try {
                    XmlSerializer ser = new XmlSerializer(typeof(MySettings));
                    return (MySettings)ser.Deserialize(stream);
                    }
                catch (InvalidOperationException)
                {
                    stream.Close();
                    File.Delete(SettingsFile);
                    return DefaultSettings;
                }
            }

        }

        
    private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                folder = Path.Combine(folder, "SamsGame");
                folder = Path.Combine(folder, "Escape!");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                return folder;
            }
        }

        private static string SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "Settings.xml");
            }
        }
        private static MySettings DefaultSettings
        {
            get
            {
                return new MySettings
                {
                    MyNumber = 100100,
                };
            }
        }



    }

}
