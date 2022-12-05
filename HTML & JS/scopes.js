//Block Scope: let and const provides block level scope which means that 
//the variable declared inside { } can not be accessed from the outside block.
let msg = "Hello World"

console.log(msg)
 
//------------------------------------------------

//Global Scope: var provides a global level scope which means that 
//the variable declared inside { } can be accessed by anywhere.
{
    var a = 10;
}

console.log(a)