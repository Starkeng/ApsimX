﻿namespace Models.Soils
{
    using Interfaces;
    using System;
    using Models.Core;
    using Newtonsoft.Json;
    using Models.Soils.Nutrients;

    /// <summary>This class encapsulates a SoilNitrogen model NH4 solute.</summary>
    [Serializable]
    [ValidParent(ParentType = typeof(SoilNitrogen))]
    public class SoilNitrogenPlantAvailableNH4 : Model, ISolute
    {
        [Link(Type = LinkType.Ancestor)]
        SoilNitrogen parent = null;

        /// <summary>Solute amount (kg/ha)</summary>
        [JsonIgnore]
        public double[] kgha
        {
            get
            {
                return parent.CalculatePlantAvailableNH4();
            }
            set
            {
                SetKgHa(SoluteSetterType.Plant, value);
            }
        }

        /// <summary>Solute amount (ppm)</summary>
        public double[] ppm { get { return parent.Soil.kgha2ppm(kgha); } }

        /// <summary>Setter for kgha.</summary>
        /// <param name="callingModelType">Type of calling model.</param>
        /// <param name="value">New values.</param>
        public void SetKgHa(SoluteSetterType callingModelType, double[] value)
        {
            parent.SetPlantAvailableNH4(callingModelType, value);
        }


        /// <summary>Setter for kgha delta.</summary>
        /// <param name="callingModelType">Type of calling model</param>
        /// <param name="delta">New delta values</param>
        public void AddKgHaDelta(SoluteSetterType callingModelType, double[] delta)
        {
            throw new NotImplementedException("should not be trying to set plant available nh4");
        }
    }
}
