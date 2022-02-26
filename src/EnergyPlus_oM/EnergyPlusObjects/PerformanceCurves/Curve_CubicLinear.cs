using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Cubic-linear curve with two independent variables. Input consists of the curve name, the six coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = (C1 + C2*x + C3*x**2 + C4*x**3) + (C5 + C6*x)*y")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_CubicLinear : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="coefficient1_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient2_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2X { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient3_x_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3X2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient4_x_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient4X3 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient5_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient5Y { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient6_x_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient6XY { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfX { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfX { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfY { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfY { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty(PropertyName="minimum_curve_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty(PropertyName="maximum_curve_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCurveOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="input_unit_type_for_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_CubicLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_CubicLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_CubicLinear_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_CubicLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_CubicLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_CubicLinear_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty(PropertyName="output_unit_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_CubicLinear_OutputUnitType OutputUnitType { get; set; } = (Curve_CubicLinear_OutputUnitType)Enum.Parse(typeof(Curve_CubicLinear_OutputUnitType), "Dimensionless");
    }
}