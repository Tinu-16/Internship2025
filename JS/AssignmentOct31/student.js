var students=[
  {
    "FirstName": "John",
    "LastName": "Doe",
    "Age": 20,
    "Department": "Computer Science"
  },
  {
    "FirstName": "Jane",
    "LastName": "Smith",
    "Age": 22,
    "Department": "Physics"
  },
  {
    "FirstName": "Michael",
    "LastName": "Johnson",
    "Age": 21, 
    "Department": "Mathematics"
  },
  {
    "FirstName": "Sarah",
    "LastName": "Williams",
    "Age": 19,
    "Department": "Computer Science"
  },
  {
    "FirstName": "Robert",
    "LastName": "Brown",
    "Age": 23,
    "Department": "Mathematics"
  },
  {
    "FirstName": "Emily",
    "LastName": "Davis",
    "Age": 20,
    "Department": "Computer Science"
  }
]
//List the students whose department is computer science.
var cs=students.filter(h =>h.Department =="Computer Science")
console.log(cs)
//List the first name of students whose age is greater than  21
console.log(students.filter(h => h.Age > 21).map(h => h.FirstName))
//Check whether a student having a first name as Robert is present in the Computer Science Department. The result should be in boolean type
var present = students.some(h => h.FirstName =="Robert" && h.Department=="Computer Science")
console.log(present)
//Check whether there is any student whose age is greater than 23 is studying in the Maths department.The result should be in boolean type
var student=students.some(h => h.Age > 23 && h.Department=="Maths")
console.log(student)
//Check whether all the students are above an age group of 18.The result should be in boolean type.
var age= students.every(s => s.Age > 18);
console.log(age);
 //Assuming that there is only one student having a first name as John, Print his department name.
const department=students.find(h => h.FirstName =="John").Department
console.log(department)

