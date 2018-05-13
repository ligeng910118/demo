using System;
namespace simpleapp.AddClass
{
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute(string vehicalDescription)
        {
            Description = vehicalDescription;
        }

        public VehicleDescriptionAttribute(){}
    }
}
