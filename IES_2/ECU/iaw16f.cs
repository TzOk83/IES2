using System.IO.Ports;
using IES_2.Res;

namespace IES_2.ECU
{
    class iaw16f : ecu
    {
        public const string name = "IAW-6F/16F";
        public const string longName = "Magneti-Marelli IAW-6F/16F SPI";
        public static string[,] cars = new string[,] {
                {"55D085859443", "Cinquecento 899 SPI ECE F2"},
                {"55D0858694C4", "Cinquecento 1108 SPI ECE F2"},
                {"55D0850194BF", "Punto 1.1 SPI Em.04 Est Europa"},
                {"55D085029440", "Punto 55 1.1 SPI 5M/6M ECE F2"},
                {"55D0850494C2", "Punto 60 1.2 SPI CM ECE F2 T.i.T."},
                {"55D085079445", "Punto Selecta 1.2 SPI ECE F2"},
                {"554C851092C8", "Panda 1000 SPI ECOL"},
                {"55D085089446", "Panda 1000 SPI ECE F2"},
                {"55D0850B9449", "Panda 1108 SPI CA ECE F2"},
                {"55D0850E15CD", "Tipo/Tempra 1.6 SPI USA'83 (TOFAS)"},
                {"55D08510154F", "Lancia Y 1.2 SPI CA ECE F2"},
                {"55D0858994C7", "Panda 899 SPI ECE F2"},
                {"55D0858A94C8", "Panda 1108 4x4/4x4 ECE F2"},
                {"55D0858C15CB", "Tipo/Tempra 1.6 SPI Em.04 (TOFAS)"},
                {"55D0858F15CE", "Lancia Y 1.2 SPI CM ECE F2"},
                {"55D085911651", "Tipo 1372 SPI ECE 04 (TOFAS)"},
                {"55D085921652", "131 Bn/Sw 1.6 SPI USA'83 (TOFAS)"},
                {"55D085139754", "Seicento 0.9 CM SPI F2"}
            };
        public static string GetCars()
        {
            string result = "";
            for (int i = 0; i < cars.GetLength(0); i++)
            {
                result += cars[i, 1] + System.Environment.NewLine;
            }
            return result;
        }
        public override string GetCarModel()
        {
            string result = lang.UnknownISO;
            for (int i = 0; i < cars.GetUpperBound(0) + 1; i++)
            {
                if (ISO == cars[i, 0])
                {
                    result = cars[i, 1];
                    break;
                }
            }
            return result;
        }
        public static bool CheckISO()
        {
            if (CODRIC == null) return false;
            if (ISO == null) return false;
            if (ISO.Substring(2, 4) == "D085") return true;
            return false;
        }
        public static bool CheckCODRIC()
        {
            if (CODRIC == null) return false;
            if (CODRIC.Substring(0, 5) == "61602") return true;
            return false;
        }
        public iaw16f(ref SerialPort sPort)
            : base(ref sPort)
        {
            engineData = new dataElement[] {
                new dataElement(lang.PERIODE, lang.rpm, "0", new byte[] { 0x01, 0x02 }, new dataElement.ValDecode(PERIODE)),
                new dataElement(lang.T_INJ_AP, "ms", "0.00", new byte[] { 0x03, 0x04 }, new dataElement.ValDecode(T_INJ_AP)),
                new dataElement(lang.AVANCE, "°", "0.00", new byte[] { 0x05 }, new dataElement.ValDecode(AVANCE)),
                new dataElement(lang.MP2_MP8, "hPa", "0", new byte[] { 0x06 }, new dataElement.ValDecode(MP2_MP8)),
                new dataElement(lang.MT_AIR_L, "°C", "0", new byte[] { 0x07 }, new dataElement.ValDecode(MT_AIR_L)),
                new dataElement(lang.MT_EAU_L, "°C", "0", new byte[] { 0x08 }, new dataElement.ValDecode(MT_EAU_L)),
                new dataElement(lang.ANG_PAP0, "°", "0.00", new byte[] { 0x09 }, new dataElement.ValDecode(ANG_PAP0)),
                new dataElement(lang.V_BATT, "V", "0.00", new byte[] { 0x0A }, new dataElement.ValDecode(M_VBATT)),
                new dataElement(lang.K_O2, "", "0.00", new byte[] { 0x0B }, new dataElement.ValDecode(K_O2)),
                new dataElement(lang.ALFAR, lang.steps, "0", new byte[] { 0x0C }, new dataElement.ValDecode(ALFAR)),
                new dataElement(lang.INTEGR, "", "0", new byte[] { 0x0D }, new dataElement.ValDecode(INTEGR)),
                new dataElement(lang.PROP, "", "0", new byte[] { 0x0E }, new dataElement.ValDecode(PROP)),
                new dataElement(lang.TRIMRAM, lang.steps, "0", new byte[] { 0x0F }, new dataElement.ValDecode(TRIMRAM)),
                new dataElement(lang.ALFAU, "", "0", new byte[] { 0x22, 0x23 }, new dataElement.ValDecode(ALFAU)),
                new dataElement(lang.ALFAUC, "", "0", new byte[] { 0x24, 0x25 }, new dataElement.ValDecode(ALFAUC)),
                new dataElement(lang.CONS_REG, lang.rpm, "0", new byte[] { 0x26 }, new dataElement.ValDecode(CONS_REG)),
                new dataElement(lang.OFNNTR, lang.rpm, "0", new byte[] { 0x27 }, new dataElement.ValDecode(OFNNTR)),
                new dataElement(lang.DELREG, "", "0", new byte[] { 0x28 }, new dataElement.ValDecode(DELREG)),
                new dataElement(lang.ALFAFTR, "", "0", new byte[] { 0x29 }, new dataElement.ValDecode(ALFAFTR)),
                new dataElement(lang.ADOFFSET, "", "0", new byte[] { 0x32, 0x33 }, new dataElement.ValDecode(ADOFFSET)),
                new dataElement(lang.ADOFFPURG, "", "0", new byte[] { 0x34, 0x35 }, new dataElement.ValDecode(ADOFFPURG)),
                new dataElement(lang.ADOFFPL, "", "0", new byte[] { 0x36, 0x37 }, new dataElement.ValDecode(ADOFFPL)),
                new dataElement(lang.ADGAIN, "", "0", new byte[] { 0x38, 0x39 }, new dataElement.ValDecode(ADGAIN)),
                new dataElement(lang.StaEngRun, "", lang.yes_no, new byte[] { 0x13 }, new dataElement.ValDecode(S2)),
                new dataElement(lang.StaSensOK, "", lang.yes_no, new byte[] { 0x13 }, new dataElement.ValDecode(S3)),
                new dataElement(lang.StaThrMM, "", lang.yes_no, new byte[] { 0x13 }, new dataElement.ValDecode(S4)),
                new dataElement(lang.StaClLoop, "", lang.yes_no, new byte[] { 0x13 }, new dataElement.ValDecode(S5)),
                new dataElement(lang.StaAirCoON, "", lang.yes_no, new byte[] { 0x13 }, new dataElement.ValDecode(S6)),
                new dataElement(lang.StaMixACOK, "", lang.yes_no, new byte[] { 0x13 }, new dataElement.ValDecode(S7)),
                new dataElement(lang.StaStepACOK, "", lang.yes_no, new byte[] { 0x2A }, new dataElement.ValDecode(S23)),
                new dataElement(lang.StaPLatchOK, "", lang.yes_no, new byte[] { 0x2A }, new dataElement.ValDecode(S27)) };
            activeTest = new testElement[] {
                new testElement( lang.FuelPump, false, 30, new byte[] { 0x80 }),
                new testElement( lang.Injector, false, 5, new byte[] { 0x81 }),
                new testElement( lang.Coil1, false, 5, new byte[] { 0x82 }),
                new testElement( lang.Coil2, false, 5, new byte[] { 0x83 }),
                new testElement( lang.EVAP, false, 7, new byte[] { 0x85 }),
                new testElement( lang.REVmeter, false, 2, new byte[] { 0x86 }),
                new testElement( lang.ACrelay, false, 30, new byte[] { 0x87 }),
                new testElement( lang.GenericRelay, false, 30, new byte[] { 0x88 })};
                //new testElement( lang.Stepper, true, 30, new byte[] { 0x8E })};
            adjustments = new adjustElement[] {
                new adjustElement( lang.ToggleTrimAC, 0x00, 0x00, new byte[] { 0x89 }, null, "toggle"),
                new adjustElement( lang.ToggleStepAC, 0x00, 0x00, new byte[] { 0x91 }, null, "toggle"),
                new adjustElement( lang.TrimReset, 0x00, 0x00, new byte[] { 0x89, 0x89 }, null, "toggle"),
                new adjustElement( lang.StepReset, 0x00, 0x00, new byte[] { 0x91, 0x91 }, null, "toggle"),
                new adjustElement( lang.TrimSet, 0x0F, 0xFF, new byte[] { 0x8F }, new byte[] { 0xFF }, "onebyte"),
                new adjustElement( lang.StepSet, 0x29, 0xFF, new byte[] { 0x92 }, new byte[] { 0xFF }, "onebyte"),};
            engineErrReq = new byte[] { 0x10, 0x11, 0x12, 0x14, 0x15, 0x16, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x30 };
            immoErrReq = new byte[] { 0x71, 0x72 };
            clearCodes = new testElement("", false, 10, new byte[] { 0x84 });
            engineErrors = new errorElement[] {
                new errorElement( lang.ErrTPS, 0x10, 0, 0x14, 0, 0x2B, 0, 0x2E, 0, lang.ShortToGND, lang.ShortToVcc, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrMAP, 0x10, 0, 0x14, 1, 0x2B, 0, 0x2E, 1, lang.ShortToVcc, lang.ShortToGND, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrLambda, 0x10, 0, 0x14, 2, 0x2B, 0, 0x2E, 2, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrECT, 0x10, 0, 0x14, 3, 0x2B, 0, 0x2E, 3, lang.ShortToGND, lang.ShortToVcc, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrIAT, 0x10, 0, 0x14, 4, 0x2B, 0, 0x2E, 4, lang.ShortToGND, lang.ShortToVcc, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrBattV, 0x10, 0, 0x14, 5, 0x2B, 0, 0x2E, 5, lang.AtMAX, lang.AtMIN, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrIdleReg, 0x10, 0, 0x14, 6, 0x2B, 0, 0x2E, 6, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrI8, 0x10, 0, 0x14, 7, 0x2B, 0, 0x2E, 7, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrInj, 0x11, 0, 0x15, 0, 0x2C, 0, 0x2F, 0, lang.Therm, lang.OpenCircuit, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrCoil1, 0x11, 0, 0x15, 1, 0x2C, 0, 0x2F, 1, lang.ShortToVcc, lang.ShortToGNDorOpen, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrCoil2, 0x11, 0, 0x15, 2, 0x2C, 0, 0x2F, 2, lang.ShortToVcc, lang.ShortToGNDorOpen, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrIAV, 0x11, 0, 0x15, 3, 0x2C, 0, 0x2F, 3, lang.Therm, lang.OpenCircuit, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrEVAP, 0x11, 0, 0x15, 4, 0x2C, 0, 0x2F, 4, lang.ShortToVcc, lang.ShortToGNDorOpen, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrAirCo, 0x11, 0, 0x15, 5, 0x2C, 0, 0x2F, 5, lang.ShortToVcc, lang.ShortToGNDorOpen, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrFuelPump, 0x11, 0, 0x15, 6, 0x2C, 0, 0x2F, 6, lang.ShortToVcc, lang.ShortToGNDorOpen, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrGenRel, 0x11, 0, 0x15, 7, 0x2C, 0, 0x2F, 7, lang.ShortToVcc, lang.ShortToGNDorOpen, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrACParam, 0x12, 0, 0x16, 0, 0x2D, 0, 0x30, 0, lang.MaxRICH, lang.MaxLEAN, new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrRAM, 0x12, 0, 0x16, 1, 0x2D, 0, 0x30, 1, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrROM, 0x12, 0, 0x16, 2, 0x2D, 0, 0x30, 2, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrEEPROM, 0x12, 0, 0x16, 3, 0x2D, 0, 0x30, 3, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrCPU, 0x12, 0, 0x16, 4, 0x2D, 0, 0x30, 4, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrRPMSens, 0x12, 0, 0x16, 5, 0x2D, 0, 0x30, 5, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrF7, 0x12, 0, 0x16, 6, 0x2D, 0, 0x30, 6, "", "", new errorElement.ErrDecode(err16F)), 
                new errorElement( lang.ErrF8, 0x12, 0, 0x16, 7, 0x2D, 0, 0x30, 7, "", "", new errorElement.ErrDecode(err16F))
            };
            immoErrors = new errorElement[] {
                new errorElement( lang.ErrNoSync, 0x71, 0, 0x72, 0, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrStartDis, 0x71, 0, 0x72, 1, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrUniCode, 0x71, 0, 0x72, 2, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrC4, 0x71, 0, 0x72, 3, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrBackdoor, 0x71, 0, 0x72, 4, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrKeyCode, 0x71, 0, 0x72, 5, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrUnrCode, 0x71, 0, 0x72, 6, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE)), 
                new errorElement( lang.ErrLinkDown, 0x71, 0, 0x72, 7, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(errCODE))
            };
        }

        #region Live Data decoding functions
        private static decimal PERIODE() // Engine Speed
        {
            if ((Buffer[0x01] | Buffer[0x02]) == 0)
                return 0;
            else if ((Buffer[0x01] & Buffer[0x02]) == 255)
                return 0;
            else
                return (decimal)(15e+6 / unchecked(((ushort)Buffer[0x01]) << 8 | (ushort)Buffer[0x02]));
        }
        private static decimal T_INJ_AP() { return (decimal)(unchecked(((ushort)Buffer[0x03]) << 8 | (ushort)Buffer[0x04]) / 500.0); }// Injection Duration
        private static decimal AVANCE() { return (decimal)(Buffer[0x05] / 2.0); }// Ignition Advance
        private static decimal MP2_MP8() { return (decimal)(Buffer[0x06] * 4); }// Manifold Absolute Pressure
        private static decimal MT_AIR_L() { return (decimal)(Buffer[0x07] - 40); }// Air Temperature
        private static decimal MT_EAU_L() { return (decimal)(Buffer[0x08] - 40); }// Water Temperature
        private static decimal ANG_PAP0() { return (decimal)(Buffer[0x09] * 0.4234 - 2.9638); }// Throttle Angle
        private static decimal M_VBATT() { return (decimal)(Buffer[0x0A] * 0.0625); }// Battery Voltage
        private static decimal K_O2() { return (decimal)(Buffer[0x0B] * 0.002656 + 0.66); }// Lambda Probe Correction
        private static decimal ALFAR() { return (decimal)Buffer[0x0C]; }// Idle Stepper Motor Position
        private static decimal INTEGR() { return unchecked((sbyte)(Buffer[0x0D])); }// Idle Stepper Integral Gain (2's complement)
        private static decimal PROP() { return unchecked((sbyte)(Buffer[0x0E])); }// Idle Stepper Proportional Gain (2's complement)
        private static decimal TRIMRAM() { return (decimal)(Buffer[0x0F] - 128); }// Trimmer Position
        private static decimal ALFAU() { return unchecked((short)(((ushort)Buffer[0x22]) << 8 | (ushort)Buffer[0x23])); }// AutoCalibration Correction
        private static decimal ALFAUC() { return unchecked((short)(((ushort)Buffer[0x24]) << 8 | (ushort)Buffer[0x25])); }// AutoCalibration Correction with A/C
        private static decimal CONS_REG() { return (decimal)(Buffer[0x26] * 8); }// Minimum Engine Speed (Desired)
        private static decimal OFNNTR() { return (decimal)((Buffer[0x27] - 128) * 8); }// Minimum Offset turns
        private static decimal DELREG() { return (decimal)(Buffer[0x28] - 128); }// Stepper Correction (Delta)
        private static decimal ALFAFTR() { return (decimal)(Buffer[0x29] - 128); }// Stepper Correction from FLT
        private static decimal ADOFFSET() { return unchecked((short)(((ushort)Buffer[0x32]) << 8 | (ushort)Buffer[0x33])); }// AC Offset Parameter (Minimum with Canister deactivated)
        private static decimal ADOFFPURG() { return unchecked((short)(((ushort)Buffer[0x34]) << 8 | (ushort)Buffer[0x35])); }// AC Offset Parameter (Minimum with Canister activated)
        private static decimal ADOFFPL() { return unchecked((short)(((ushort)Buffer[0x36]) << 8 | (ushort)Buffer[0x37])); }// AC Offset Parameter (Minimum)
        private static decimal ADGAIN() { return unchecked((short)(((ushort)Buffer[0x38]) << 8 | (ushort)Buffer[0x39])); }// AC Gain Parameter (Midrange value)
        private static decimal S2() { return (Buffer[0x13].GetBit(1)) ? 1 : 0; }// Engine Running
        private static decimal S3() { return (Buffer[0x13].GetBit(2)) ? 1 : 0; }// Signals OK
        private static decimal S4() { return (Buffer[0x13].GetBit(3)) ? 1 : 0; }// Throttle Min/Max
        private static decimal S5() { return (Buffer[0x13].GetBit(4)) ? 1 : 0; }// Closed Loop
        private static decimal S6() { return (Buffer[0x13].GetBit(5)) ? 1 : 0; }// Air Conditioner ON
        private static decimal S7() { return (Buffer[0x13].GetBit(6)) ? 1 : 0; }// System Autocalibration OK
        private static decimal S23() { return (Buffer[0x2A].GetBit(2)) ? 1 : 0; }// Stepper Autocalibration OK
        private static decimal S27() { return (Buffer[0x2A].GetBit(6)) ? 0 : 1; }// Power-Latch OK
        #endregion
        #region Errors decoding functions
        private errorState err16F(byte rAbase, byte rVbase, byte rSbase, byte oBase, byte rAext, byte rVext, byte rSext, byte oExt, string hExt, string lExt)
        {
            errorState result = new errorState();
            result.isActive = Buffer[rAbase].GetBit(oBase);
            result.isStored = Buffer[rSbase].GetBit(oBase);
            //result.Reason = (Buffer[rAbase].GetBit(oBase) ? Buffer[rAext].GetBit(oExt) : Buffer[rSext].GetBit(oExt)) ? hExt : lExt;
            result.Reason = (Buffer[rSbase].GetBit(oBase) ? Buffer[rSext].GetBit(oExt) : Buffer[rAext].GetBit(oExt)) ? hExt : lExt;
            return result;
        }
        private errorState errCODE(byte rAbase, byte rVbase, byte rSbase, byte oBase, byte rAext, byte rVext, byte rSext, byte oExt, string hExt, string lExt)
        {
            errorState result = new errorState();
            result.isActive = Buffer[rAbase].GetBit(oBase);
            result.isStored = Buffer[rSbase].GetBit(oBase);
            result.Reason = "FIAT CODE";
            return result;
        }
        #endregion
    }
}
