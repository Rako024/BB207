using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization_and_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < 20; i++)
            {
                Student student = new Student();
                student.Name = FakeData.NameData.GetFirstName();
                student.Surname = FakeData.NameData.GetSurname();
                student.Email = FakeData.NetworkData.GetEmail();
                student.Adress = FakeData.PlaceData.GetAddress();
                student.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                students.Add(student);
            }
            GetJsonSerialization(students);
            List<Student> list = GetJsonDeserialization(@"C:/Users/Rashid/Desktop/Students.json");
            list.ForEach(student => Console.WriteLine(student));


            GetXmlSerialization(students);
            List<Student> listXML = GetXmlDeserialization(@"C:/Users/Rashid/Desktop/Students.xml");
            listXML.ForEach(student => Console.WriteLine(student));
        }

        
        public static void GetJsonSerialization(List<Student> list)
        {
            string JsonData = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"C:/Users/Rashid/Desktop/Students.json", JsonData);
        }

        public static List<Student> GetJsonDeserialization(string path)
        {
            string JsonData = File.ReadAllText(path);
            List<Student> list = JsonConvert.DeserializeObject<List<Student>>(JsonData);
            return list;
            
        }

        public static void GetXmlSerialization(List<Student> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (TextWriter writer = new StreamWriter(@"C:/Users/Rashid/Desktop/Students.xml"))
            {
                serializer.Serialize(writer, list);
            }
        }

        public static List<Student> GetXmlDeserialization(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (TextReader reader = new StreamReader(path))
            {
                List<Student> deserializedList = (List<Student>)serializer.Deserialize(reader);
                return deserializedList;
            }
        }
    }
}
