function changeStyle(attr, value)
{     
    this.style[attr] = value; 
 }  
var box = document.getElementById('box');  
window.changeStyle.call(box, "height", "200px");


//box.style.height=”200px”；