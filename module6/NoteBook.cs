namespace Employees;

public class NoteBook
{
    public static void AddNote(Employees employee, string path)
    {
        string info = $"\nID: {employee.id}#" +
                      $"Время добавления записи: {employee.timeNow}#" +
                      $"Ф.И.О.: {employee.fullName}#" +
                      $"Возраст: {employee.age}#" +
                      $"Рост: {employee.height}#" +
                      $"Дата рождения: {employee.birthday}#";

        if (!File.Exists(path))
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(info);
            }
        }
        else
        {
            FileStream fs = new FileStream(path, FileMode.Append);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(info);
            }
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