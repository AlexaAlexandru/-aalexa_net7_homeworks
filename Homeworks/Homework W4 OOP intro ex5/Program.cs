using HomeWork_W4_OOP_intro;

College college = new College();
college.name = "UMF Grigore T.Popa";
Student student = new Student("Alex", DateTime.Now.AddYears(22), DateTime.Now.AddYears(24), DateTime.Now.AddYears(-25),college);

Console.WriteLine(student.IsStillStudent());
Console.WriteLine(student.GetAge());

student.Print();



College college1 = new College();
college1.name = " Cuza";

Professor professor = new Professor("Giacomo","SportMedicine",college1) ;



professor.Print();

professor.Check();




