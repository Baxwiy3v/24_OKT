

//TASK-1

//using Delegates.Models;
//using System;
//using System.Collections.Generic;

//namespace delegates { 

//class Program
//{
//    delegate bool PersonFilter(Person person);

//    static void Main()
//    {
//        List<Person> people = new List<Person>
//        {
//            new Person { Name = "Kamil", Surname = "baxisov", Age = 19 },
//            new Person { Name = "Aqil", Surname = "baxsiyev", Age = 21 },
//            new Person { Name = "tural", Surname = "pertrova", Age = 19 },
//            new Person { Name = "Kamil", Surname = "verdiyev", Age = 22 },
//            new Person { Name = "vaqif", Surname = "qarayev", Age = 28 }
//        };


//        PersonFilter kamilFilter = person => person.Name == "Kamil";
//        List<Person> kamilPeople = FilterPeople(people, kamilFilter);

//        Console.WriteLine("Adı Kamil olanlar:");
//        PrintPeople(kamilPeople);


//        PersonFilter ovOvaFilter = person => person.Surname.EndsWith("ov") || person.Surname.EndsWith("ova");
//        List<Person> ovOvaPeople = FilterPeople(people, ovOvaFilter);

//        Console.WriteLine("\nSoyadı 'ov' veya 'ova' ile bitenler:");
//        PrintPeople(ovOvaPeople);


//        PersonFilter above20Filter = person => person.Age >= 20;
//        List<Person> above20YearsOld = FilterPeople(people, above20Filter);

//        Console.WriteLine("\nYaşı 20 ve üstü olanlar:");
//        PrintPeople(above20YearsOld);
//    }

//    static List<Person> FilterPeople(List<Person> people, PersonFilter filter)
//    {
//        List<Person> filteredPeople = new List<Person>();
//        foreach (var person in people)
//        {
//            if (filter(person))
//            {
//                filteredPeople.Add(person);
//            }
//        }
//        return filteredPeople;
//    }

//    static void PrintPeople(List<Person> people)
//    {
//        foreach (var person in people)
//        {
//            Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
//        }
//    }
//}

//}


//***************************************************************************************************





//TASK-2

//using Delegates.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
    
//    delegate void DisplayExamInfo(Exam exam);

//    static void Main()
//    {
        
//        var exams = new List<Exam>
//        {
//            new Exam { Subject = "Math", ExamDuration = TimeSpan.FromHours(2), StartDate = DateTime.Parse("2023-10-10 10:00") },
//            new Exam { Subject = "Science", ExamDuration = TimeSpan.FromHours(3), StartDate = DateTime.Parse("2023-10-15 16:30") },
//            new Exam { Subject = "History", ExamDuration = TimeSpan.FromHours(1.5), StartDate = DateTime.Parse("2023-10-25 9:15") },
//        };

        
//        var examsLastWeek = exams.Where(e => (DateTime.Now - e.StartDate).TotalDays <= 7).ToList();

       
//        var examsLongerThan2Hours = exams.Where(e => e.ExamDuration.TotalHours > 2).ToList();

  
//        var ongoingExams = exams.Where(e => e.StartDate <= DateTime.Now && e.EndDate > DateTime.Now).ToList();

       
//        DisplayExamList("Son 1 heftede imtahanlar:", examsLastWeek, DisplayExamInfoAction);
//        DisplayExamList("İmtahanlar 2 saatdan çox:", examsLongerThan2Hours, DisplayExamInfoAction);
//        DisplayExamList("Davam eden imtahanlar:", ongoingExams, DisplayExamInfoAction);
//    }

//    static void DisplayExamInfoAction(Exam exam)
//    {
//        Console.WriteLine($"Subject: {exam.Subject}, Duration: {exam.ExamDuration.TotalHours} hours");
//    }

//    static void DisplayExamList(string message, List<Exam> exams, DisplayExamInfo displayExamInfo)
//    {
//        Console.WriteLine(message);
//        foreach (var exam in exams)
//        {
//            displayExamInfo(exam);
//        }
//        Console.WriteLine();
//    }
//}