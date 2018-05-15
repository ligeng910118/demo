/**
 * 
 */

function Type()
{}

Type.prototype = {
		callSome:function()
		{
			function callSomeFunction(someFunction,someArgument)
			{
				return someFunction(someArgument);
			}
			
			function getName(name)
			{
				return "hello " + name;
			}
			
			function add(num)
			{
				return num + 10;
			}
			
			var result = callSomeFunction(add,20);
			console.log(result);
			var name = callSomeFunction(getName,"li");
			console.log(name);
		},
		inst:function()
		{
			function displayInfo(args)
			{
				var output = "";
				if(typeof args.name == "string")
				{
					output += "name: " + args.name + "\n";
				}
				
				if(typeof args.age == "number")
				{
					output += "age: " + args.age + "\n"
				}
				console.log(output);
			}
			displayInfo({name:"nick",age:13});
			displayInfo({name:"mikc"});						
		},
		test:function()
		{
			var message = 6;
			console.log(message);
		},
		
		obj:function()
		{
			var obj1 = {name:"nick"};
			var obj2 = obj1;
			console.log(obj2.name);
			obj2.name="milk";
			console.log(obj1.name);
		},
		argument:function()
		{
			function addTen(num)
			{
				num += 10;
				return num;
			}
			var cout = 30;
			var result = addTen(cout);
			console.log(cout);
			console.log(result);
		},
		objArgument:function()
		{
			function setName(obj)
			{
				obj.name = "nick";
			}
			var person = {};
			setName(person);
			console.log(person);
		}
}