var addText = function(objId)
{
    var say = function(str)
    {
       document.getElementById(objId).innerHTML = str;
    };

    return {
        say : say,
    }
}