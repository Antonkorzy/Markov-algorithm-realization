using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace НАМ
{
    [Serializable]
    public partial class WriteRead
    {
        public string[] mas1;
        public void CreateFile(string[,] mas, string path)
        {

            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter w = new BinaryFormatter();
            w.Serialize(fs, mas); // Запись
            fs.Close();

        }
        public string[,] OpenFile(string path)
        {

            FileStream f2 = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string[,] mas = (string[,])bf.Deserialize(f2);// восстановление объекта
            f2.Close();
            return mas;
        }
    }
}
