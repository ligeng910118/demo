function foo()
{
    var something = "cool";
    var another = [1, 2, 4];

    function doSomething()
    {
        console.log(something);
    }

    function doAnother()
    {
        console.log(another.join("!"));
    }

    return {
        doSomething: doSomething,
        doAnother: doAnother,
    };
}