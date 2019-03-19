﻿

namespace UnitTests.Soils
{
    using Models;
    using Models.WaterModel;
    using System;
    using APSIM.Shared.Soils;
    using Models.Core;

    [Serializable]
    class MockSoil : Model, ISoil
    {
        public double[] CL { get; set; }

        public double Infiltration { get; set; }

        public double[] NH4 { get; set; }

        public double[] NO3 { get; set; }

        public double PotentialRunoff { get; set; }

        public APSIM.Shared.Soils.Soil Properties { get; set; }

        public double[] Water { get; set; }
    }
}