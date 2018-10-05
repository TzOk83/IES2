using System.IO.Ports;
using IES_2.Res;

namespace IES_2.ECU
{
    class iaw18f : ecu
    {
        public const string name = "IAW-8F/18F";
        public const string longName = "Magneti-Marelli IAW-8F/18F MPI";
        public static string[,] cars = new string[,] {
                {"55318002941C", "Punto 75 1.2 Fire 8V ECE F2"},
                {"5531808A1323", "Punto 75 1.2 Fire 8V ECE ECOL"},
                {"5531800E97AB", "Palio 1.2 Fire 8V ECE F2"},
                {"5531800794A1", "Delta/Dedra Bn/Sw 1.8 ECE F2"},
                {"55318083949D", "Alfa 145/146 1.3 Boxer ECE F2"},
                {"55318085941F", "Delta 1.8 90 CV ECE F2"},
                {"553180869420", "Tipo/Tempra Bn/Sw 1.8 ECE F2"}
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
            if (ISO == null) return false;
            if (ISO.Substring(2, 4) == "3180") return true;
            return false;
        }
        public static bool CheckCODRIC()
        {
            if (CODRIC == null) return false;
            if (CODRIC.Substring(0, 5) == "61600") return true;
            return false;
        }
        public iaw18f(ref SerialPort sPort)
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
                new dataElement(lang.CONS_REG, lang.rpm, "0", new byte[] { 0x16 }, new dataElement.ValDecode(CONS_REG)),
                new dataElement(lang.OFNNTR, lang.rpm, "0", new byte[] { 0x15 }, new dataElement.ValDecode(OFNNTR)),
                new dataElement(lang.StaEngRun, "", lang.yes_no, new byte[] { 0x36 }, new dataElement.ValDecode(S2)),
                new dataElement(lang.StaSensOK, "", lang.yes_no, new byte[] { 0x36 }, new dataElement.ValDecode(S3)),
                new dataElement(lang.StaThrMM, "", lang.yes_no, new byte[] { 0x36 }, new dataElement.ValDecode(S4)),
                new dataElement(lang.StaClLoop, "", lang.yes_no, new byte[] { 0x36 }, new dataElement.ValDecode(S5)),
                new dataElement(lang.StaAirCoON, "", lang.yes_no, new byte[] { 0x36 }, new dataElement.ValDecode(S6)),
                new dataElement(lang.StaMixACOK, "", lang.yes_no, new byte[] { 0x36 }, new dataElement.ValDecode(S7)),
                new dataElement(lang.StaAdvDecr, "", lang.yes_no, new byte[] { 0x37 }, new dataElement.ValDecode(S25)),
                new dataElement(lang.StaStepACOK, "", lang.yes_no, new byte[] { 0x37 }, new dataElement.ValDecode(S26)),
                new dataElement(lang.StaGearEng, "", lang.yes_no, new byte[] { 0x37 }, new dataElement.ValDecode(S27)) };
            activeTest = new testElement[] {
                new testElement( lang.FuelPump, false, 30, new byte[] { 0x80 }),
                new testElement( lang.Injectors, false, 5, new byte[] { 0x81 }),
                new testElement( lang.Coil1, false, 5, new byte[] { 0x82 }),
                new testElement( lang.Coil2, false, 5, new byte[] { 0x83 }),
                new testElement( lang.EVAP, false, 7, new byte[] { 0x85 }),
                new testElement( lang.REVmeter, false, 2, new byte[] { 0x86 }),
                new testElement( lang.ACrelay, false, 30, new byte[] { 0x87 }),
                new testElement( lang.MIL, false, 30, new byte[] { 0x88 }),
                new testElement( lang.EGR, false, 30, new byte[] { 0x89 }),
                new testElement( lang.ConMeter, false, 30, new byte[] { 0x8A }) };
            adjustments = new adjustElement[] {
                new adjustElement( lang.ToggleTrimAC, 0x00, 0x00, new byte[] { 0x8D }, null, "toggle"),
                new adjustElement( lang.ToggleStepAC, 0x00, 0x00, new byte[] { 0x91 }, null, "toggle"),
                new adjustElement( lang.TrimReset, 0x00, 0x00, new byte[] { 0x8D, 0x8D }, null, "toggle"),
                new adjustElement( lang.StepReset, 0x00, 0x00, new byte[] { 0x91, 0x91 }, null, "toggle")};
            engineErrReq = new byte[] { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x39, 0x3A, 0x3B, 0x3C, 0x3D, 0x3E, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45 };
            immoErrReq = new byte[] { 0x71, 0x72 };
            clearCodes = new testElement("", false, 10, new byte[] { 0x84 });
            engineErrors = new errorElement[] {
                new errorElement( lang.ErrTPS, 0x30, 0x39, 0x40, 0, 0x35, 0x3E, 0x45, 5, lang.ShortToGND, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrMAP, 0x30, 0x39, 0x40, 1, 0x35, 0x3E, 0x45, 7, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrLambda, 0x30, 0x39, 0x40, 2, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrECT, 0x30, 0x39, 0x40, 3, 0x35, 0x3E, 0x45, 3, lang.ShortToGND, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrIAT, 0x30, 0x39, 0x40, 4, 0x35, 0x3E, 0x45, 4, lang.ShortToGND, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrBattV, 0x30, 0x39, 0x40, 5, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrIdleReg, 0x30, 0x39, 0x40, 6, 0x35, 0x3E, 0x45, 1, lang.NoAir, lang.TooMuchAir, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrKnockS, 0x30, 0x39, 0x40, 7, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrInjs, 0x31, 0x3A, 0x41, 0, 0x34, 0x3D, 0x44, 0, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrCoil1, 0x31, 0x3A, 0x41, 1, 0x34, 0x3D, 0x44, 1, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrCoil2, 0x31, 0x3A, 0x41, 2, 0x34, 0x3D, 0x44, 2, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrIAV, 0x31, 0x3A, 0x41, 3, 0x34, 0x3D, 0x44, 3, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrEVAP, 0x31, 0x3A, 0x41, 4, 0x34, 0x3D, 0x44, 4, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrAirCo, 0x31, 0x3A, 0x41, 5, 0x34, 0x3D, 0x44, 5, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrFuelPump, 0x31, 0x3A, 0x41, 6, 0x34, 0x3D, 0x44, 6, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrMIL, 0x31, 0x3A, 0x41, 7, 0x34, 0x3D, 0x44, 7, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrO1a, 0x32, 0x3B, 0x42, 0,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrO2a, 0x32, 0x3B, 0x42, 1,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrO3a, 0x32, 0x3B, 0x42, 2,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrO4a, 0x32, 0x3B, 0x42, 3,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrMixRatio, 0x32, 0x3B, 0x42, 4,  0x35, 0x3E, 0x45, 6, lang.MaxLEAN, lang.MaxRICH, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrWasteG, 0x32, 0x3B, 0x42, 5,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrConMet, 0x32, 0x3B, 0x42, 6,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrEGRCtrl, 0x32, 0x3B, 0x42, 7,  0x35, 0x3E, 0x45, 0, lang.ShortToGNDorOpen, lang.ShortToVcc, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrACParam, 0x33, 0x3C, 0x43, 0,  0x35, 0x3E, 0x45, 2, lang.MaxLEAN, lang.MaxRICH, new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrROM, 0x33, 0x3C, 0x43, 1,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrRAM, 0x33, 0x3C, 0x43, 2,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrEEPROM, 0x33, 0x3C, 0x43, 3,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrCPU, 0x33, 0x3C, 0x43, 4,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrRPMSens, 0x33, 0x3C, 0x43, 5,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrAutoTrans, 0x33, 0x3C, 0x43, 6,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F)), 
                new errorElement( lang.ErrEGRVal, 0x33, 0x3C, 0x43, 7,  0, 0, 0, 0, "", "", new errorElement.ErrDecode(err18F))
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
        private static decimal K_O2() { return (decimal)(Buffer[0x0B] * 0.00196 + 0.75); }// Lambda Probe Correction
        private static decimal ALFAR() { return (decimal)Buffer[0x0C]; }// Idle Stepper Motor Position
        private static decimal INTEGR() { return unchecked((sbyte)(Buffer[0x0D])); }// Idle Stepper Integral Gain (2's complement)
        private static decimal PROP() { return unchecked((sbyte)(Buffer[0x0E])); }// Idle Stepper Proportional Gain (2's complement)
        private static decimal TRIMRAM() { return (decimal)(Buffer[0x0F] - 128); }// Trimmer Position
        private static decimal CONS_REG() { return (decimal)(Buffer[0x16] * 8); }// Minimum Engine Speed (Desired)
        private static decimal OFNNTR() { return (decimal)((Buffer[0x15] - 128) * 8); }// Minimum Offset turns
        private static decimal S2() { return (Buffer[0x36].GetBit(1)) ? 1 : 0; }// Engine Running
        private static decimal S3() { return (Buffer[0x36].GetBit(2)) ? 1 : 0; }// Signals OK
        private static decimal S4() { return (Buffer[0x36].GetBit(3)) ? 1 : 0; }// Throttle Min/Max
        private static decimal S5() { return (Buffer[0x36].GetBit(4)) ? 1 : 0; }// Closed Loop
        private static decimal S6() { return (Buffer[0x36].GetBit(5)) ? 1 : 0; }// Air Conditioner ON
        private static decimal S7() { return (Buffer[0x36].GetBit(6)) ? 1 : 0; }// System Autocalibration OK
        private static decimal S25() { return (Buffer[0x37].GetBit(4)) ? 1 : 0; }// Advance Decrased for Knocking
        private static decimal S26() { return (Buffer[0x37].GetBit(5)) ? 1 : 0; }// Stepper Autocalibration OK
        private static decimal S27() { return (Buffer[0x37].GetBit(6)) ? 1 : 0; }// Gear Engaged
        #endregion
        #region Errors decoding functions
        private errorState err18F(byte rAbase, byte rVbase, byte rSbase, byte oBase, byte rAext, byte rVext, byte rSext, byte oExt, string hExt, string lExt)
        {
            errorState result = new errorState();
            result.isActive = Buffer[rAbase].GetBit(oBase);
            result.isVerified = Buffer[rVbase].GetBit(oBase);
            result.isStored = Buffer[rSbase].GetBit(oBase);
            if (rAext != 0)
            {
                result.Reason = (Buffer[rAbase].GetBit(oBase) ? Buffer[rAext].GetBit(oExt) : Buffer[rVbase].GetBit(oBase) ? Buffer[rVext].GetBit(oExt) : Buffer[rSext].GetBit(oExt)) ? hExt : lExt;
            }
            else
            {
                result.Reason = "";
            }
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
