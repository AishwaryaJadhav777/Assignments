
//TypeScript Access Modifiers //Public

class Student1 {
    studName: string;
    studRollNo: number;
    studSection: string;
    studCity: string;
    studRegNumber: number;
}
let obj = new Student1();
obj.studName = "Aishwarya";
obj.studRollNo = 101;
obj.studSection = "A";
obj.studCity = "Solapur";
obj.studRegNumber = 1001;

console.log("Name of student : " + obj.studName + "\nStudent Roll Number: " + obj.studRollNo + "\nStudent Section : " + obj.studSection + "\nStudent City : " + obj.studCity + "\nStudent Registeration Number : " + obj.studRegNumber);


//Private
class Employee{
    public EmpID: number;
    private EmpName: string;

    constructor(ID: number, Name: string) {
        this.EmpID = ID;
        this.EmpName = Name;
    }
    public Display() {
        return ("Employee ID:"+ this.EmpID, +" " +"\nEmployee Name:" + this.EmpName);

        }
    }

    let Emp = new Employee(101, "Aishwarya");
    console.log(Emp.Display());


//Protected AccessModifier
class Student2{
    private StudID: number;
    protected StudName: string;

    constructor(ID: number, Name: string) {
        this.StudID = ID;
        this.StudName = Name;
    }
}
class Person extends Student2 {
    private Department: string;
    constructor(ID: number, Name: string, department: string) {
        //Properties of ParentClass
        super(ID, Name);
        this.Department = department;
    }
    public GetResult() {
        return ("Student ID:" + this.StudName + "I am in" + this.Department);
    }
}

let obj1 = new Person(101, "Aishwarya", "ComputerScience");
console.log(obj1);