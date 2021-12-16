using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class ReadingLists<T>
    {
        private string path;
        public void ChangeFilePath(string path)
        {
            this.path = path;
        }
        public List<T> FromFile()
        {
            List<T> list = new List<T>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                list = (List<T>)formatter.Deserialize(fs);
            }
            return list;
        }
        public List<T> FromDB()
        {
            return null;
        }
    }
}
