using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of interzone windows (adjacent to other zones).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Window_Interzone : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("Name of Surface (Wall, usually) the Window is on (i.e., Base Surface) Window assu" +
                     "mes the azimuth and tilt angles of the surface it is on.")]
        [JsonProperty(PropertyName="building_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description(@"Specify a surface name in an adjacent zone for known interior windows. Specify a zone name of an adjacent zone to automatically generate the interior window in the adjacent zone. a blank field will set up a Window in an adjacent zone (same zone as adjacent to base surface)")]
        [JsonProperty(PropertyName="outside_boundary_condition_object", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
                     " truncated to integer")]
        [JsonProperty(PropertyName="multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Multiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Window starting coordinate is specified relative to the Base Surface origin.")]
        [JsonProperty(PropertyName="starting_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingXCoordinate { get; set; } = null;
        

        [Description("How far up the wall the Window starts. (in 2-d, this would be a Y Coordinate)")]
        [JsonProperty(PropertyName="starting_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingZCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Length { get; set; } = null;
        

        [JsonProperty(PropertyName="height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Height { get; set; } = null;
    }
}