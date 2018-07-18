using System;
class Cooler
{
	private float _Temperature;

	public float Temperature
	{
		get{ return _Temperature; }
		set{ _Temperature = value; }
	}

	public Cooler(float temperature)
	{
		Temperature = temperature;
	}

	public void OnTemperatureChange(float newTemperature)
	{
		if(newTemperature > Temperature)
		{
			Console.WriteLine("cooler:on");
		}else{
			Console.WriteLine("cooler:off");
		}
	}
}

class Heater
{
	private float _Temperature;

	public float Temperature
	{
		get{ return _Temperature; }
		set{ _Temperature = value; }
	}

	public Heater(float temperature)
	{
		Temperature = temperature;
	}

	public void OnTemperatureChange(float newTemperature)
	{
		if(newTemperature > Temperature)
		{
			Console.WriteLine("Heater:on");
		}else{
			Console.WriteLine("Heater:off");
		}
	}
}

public class Thermostat
{
	public Action<float> OnTemperatureChange{ get;set; }

	private float _CurrentTemperature;

	public float CurrentTemperature
	{
		get{ return _CurrentTemperature; }
		set
		{
			if(value != CurrentTemperature)
			{
				_CurrentTemperature = value;
				OnTemperatureChange(value);
			}
		}
	}
}

class Program
{
	public static void Main()
	{
		Thermostat thermostat = new Thermostat();
		Heater heater = new Heater(60);
		Cooler cooler = new Cooler(80);

		thermostat.OnTemperatureChange += heater.OnTemperatureChange;
		thermostat.OnTemperatureChange += cooler.OnTemperatureChange;

		string temperature;

		Console.WriteLine("enter temperature:");
		temperature = Console.ReadLine();
		thermostat.CurrentTemperature = int.Parse(temperature);
	}
}