﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFlight
{
    public class TestFlightFailure_RemoteBroken : TestFlightFailureBase_Generic
    {
        public override void OnLoad(ConfigNode node)
        {
            base.OnLoad(node);
            this.modName = "ModuleRTAntenna";
        }
        public override void DoFailure()
        {
            base.DoFailure();
            base.SetValue("IsRTBroken", true);
        }
        public override float DoRepair()
        {
            base.DoRepair();
            base.SetValue("IsRTBroken", false);
            return 0f;
        }
    }
}
