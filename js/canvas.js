/**
 * 
 */

var model1 = function()
{
	var drawing = document.getElementById("drawing");
	
	if(drawing.getContext)
	{
		var context = drawing.getContext("2d");		
		
		
		
		context.beginPath();
		makeCycle1();
		makeCycle2();
	
		
		minute();
		hour();
		number();
		
		
		
		context.stroke();
		
		
		//colorAndBone();
		//stroke();
		//cleaeRect();
	}
	
	function number()
	{
		context.font = "bold 14px Arial";
		context.textAlign = "center";
		context.textBaseline = "middle";
		context.fillText("12",120,20);
	}
	
	function hour()
	{
		context.moveTo(100,100);
		context.lineTo(35,100);
	}
	
	function minute()
	{
		context.moveTo(100,100);
		context.lineTo(100,15);
	}
	
	function makeCycle1()
	{
		context.arc(100,100,99,0,2 * Math.PI,false);
	}
	
	function makeCycle2()
	{
		context.moveTo(194,100);
		context.arc(100,100,94,0,2 * Math.PI,false);
	}
	
	function cleaeRect()
	{
		context.clearRect(40,40,10,10);
	}
	
	function stroke()
	{
		context.strokeStyle = "#ff0000";
		context.strokeRect(10,10,50,50);
		
		context.strokeStyle = "rgba(0,0,255,0.5)";
		context.strokeRect(30,30,50,50);
	}
	
	function colorAndBone()
	{
		context.fillStyle = "rgba(255,0,0,0.5)";
		context.fillRect(10,10,50,50);
		
		context.fillStyle = "rgba(0,0,255,0.5)";
		context.fillRect(30,30,50,50);
	}
}