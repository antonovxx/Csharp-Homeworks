namespace Employees;

public class NoteBook
{
    public static bool CheckNote(string path)
    {
        if (!File.Exists(path)) 
            return false;
        else
            return true;
    }

    public static void CreateNote(Employees employee, string path)
    {
        string info = employee.ToString();
        FileStream fs = new FileStream(path, FileMode.Create);
        using (StreamWriter sw = new StreamWriter(fs))
        {
            sw.WriteLine(info);
        }
    }
    public static void AddNote(Employees employee, string path)
    {
        string info = employee.ToString();
        
        FileStream fs = new FileStream(path, FileMode.Append); 
        using (StreamWriter sw = new StreamWriter(fs)) 
        { 
            sw.WriteLine(info);
        }
    }

    public static void ReadNote(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            string text = sr.ReadToEnd();
            string[] lines = text.Split('#').ToArray();
            foreach (var line in lines)
            { 
                Console.WriteLine(line); 
            }
            sr.Close();
        }
    }
}