function Person(name, age, job)
{
    this.name = name;
    this.age = age;
    this.job = job;
    this.friends = ["Tom", "Jack"];
    if (typeof this.sayName1 != "function")
    {
        this.sayName1 = function ()
        {
            alert(this.name);
        }
    }
    if (typeof this.sayName != "function")
    {
        Person.prototype.sayName = function ()
        {
            alert(this.name);
        };
    }
}
//Person.prototype = {
//    constructor: Person, //对象字面量创建了新对象，如不指定，constructor指向了Object
//    sayName: function ()
//    {
//        alert(this.name);
//    }
//};

var person1 = new Person("Jim", 25, "Teacher");
var person2 = new Person("Lily", 20, "Actor");
person1.friends.push("Mark");
alert(person1.sayName === person2.sayName); //false
alert(person1.sayName1 === person2.sayName1); //true
//console.log("%s %s", person1.sayName1, person2.sayName1);
