using System;
using System.Xml;

class Center {
    static void Main(string[] args) {
        // Загружает файл XML в объект XmlDocument
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("D:/20-ИС/6-Семестр/УДМЯП/XML-Lab/lab1-orig.xml");

        Console.WriteLine("\n----------COORDINATION CENTER --------\n");

        XmlNode numberDepartment = xmlDoc.SelectSingleNode("/coordinating_center/departments/dep_quantity");
        Console.WriteLine("Number Department: " + numberDepartment.InnerText + "\n");

        // Пример запроса с использованием SelectNodes e XPath
        XmlNodeList departments = xmlDoc.SelectNodes("/coordinating_center/departments");

        XmlNodeList employees = xmlDoc.SelectNodes("/coordinating_center/departments/employees");

        XmlNodeList clients = xmlDoc.SelectNodes("/coordinating_center/clients");

        foreach (XmlNode department in departments) {
            string departmentName = department.SelectSingleNode("dep_name").InnerText;
            
            Console.WriteLine("Department Names: " + departmentName);
        }

        foreach (XmlNode employee in employees) {
            string employeeName = employee.SelectSingleNode("name").InnerText;
            string employeeDep = employee.SelectSingleNode("dep_employee").InnerText;
            
            Console.WriteLine("Employee: " + employeeName);
            Console.WriteLine("Employee Department: " + employeeDep);
        }

        foreach (XmlNode client in clients) {
            string clientName = client.SelectSingleNode("name").InnerText;
            string clienteType = client.SelectSingleNode("type").InnerText;

            
            Console.WriteLine("Client Name: " + clientName);
            Console.WriteLine("Client Department: " + clienteType);
        }
    }
}
