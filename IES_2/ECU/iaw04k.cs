using System.IO.Ports;
using System.Threading;
using IES_2.Res;

/*
 * Barnacle's
125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0,
125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0,
125.0, 122.1, 119.2, 116.3, 113.4, 110.5, 107.6, 104.7, 101.8,  98.9,  96.0,  93.1,  90.2,  87.3,  84.4,  81.5,
 78.6,  77.4,  76.2,  75.0,  73.8,  72.5,  71.3,  70.1,  68.9,  67.7,  66.5,  65.3,  64.1,  62.8,  61.6,  60.4,
 59.2,  58.5,  57.7,  57.0,  56.3,  55.5,  54.8,  54.1,  53.4,  52.6,  51.9,  51.2,  50.4,  49.7,  49.0,  48.2,
 47.5,  46.9,  46.3,  45.7,  45.1,  44.5,  43.9,  43.3,  42.7,  42.1,  41.5,  40.9,  40.3,  39.7,  39.1,  38.5,
 37.9,  37.4,  36.9,  36.3,  35.8,  35.3,  34.8,  34.2,  33.7,  33.2,  32.7,  32.1,  31.6,  31.1,  30.6,  30.0,
 29.5,  29.0,  28.6,  28.1,  27.6,  27.2,  26.7,  26.2,  25.8,  25.3,  24.8,  24.3,  23.9,  23.4,  22.9,  22.5,
 22.0,  21.5,  21.0,  20.5,  20.0,  19.5,  19.0,  18.5,  18.0,  17.5,  17.0,  16.5,  16.0,  15.5,  15.0,  14.5,
 14.0,  13.5,  13.0,  12.5,  12.1,  11.6,  11.1,  10.6,  10.1,   9.6,   9.1,   8.6,   8.2,   7.7,   7.2,   6.7,
  6.2,   5.7,   5.2,   4.7,   4.2,   3.7,   3.2,   2.7,   2.2,   1.7,   1.2,   0.7,   0.2,  -0.3,  -0.8,  -1.3,
 -1.8,  -2.4,  -3.1,  -3.7,  -4.3,  -4.9,  -5.6,  -6.2,  -6.8,  -7.4,  -8.1,  -8.7,  -9.3,  -9.9, -10.6, -11.2,
-11.8, -12.9, -13.9, -15.0, -16.0, -17.1, -18.1, -19.2, -20.3, -21.3, -22.4, -23.4, -24.5, -25.5, -26.6, -27.6,
-28.7, -30.3, -32.0, -33.6, -35.3, -36.9, -38.6, -40.2, -41.9, -43.5, -45.1, -46.8, -48.4, -50.1, -51.7, -53.4,
-55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0,
-55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0

 * Mine
125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 
125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 
125.0, 122.0, 119.0, 116.0, 113.0, 111.0, 108.0, 105.0, 102.0,  99.0,  96.0,  93.0,  90.0,  87.0,  84.0,  82.0, 
 79.0,  77.0,  76.0,  75.0,  74.0,  73.0,  71.0,  70.0,  69.0,  68.0,  66.0,  65.0,  64.0,  63.0,  62.0,  60.0, 
 59.0,  58.0,  58.0,  57.0,  56.0,  56.0,  55.0,  54.0,  53.0,  53.0,  52.0,  51.0,  50.0,  50.0,  49.0,  48.0, 
 48.0,  47.0,  46.0,  46.0,  45.0,  45.0,  44.0,  43.0,  43.0,  42.0,  42.0,  41.0,  40.0,  40.0,  39.0,  39.0, 
 38.0,  37.0,  37.0,  36.0,  36.0,  35.0,  35.0,  34.0,  34.0,  33.0,  33.0,  32.0,  32.0,  31.0,  31.0,  30.0, 
 30.0,  29.0,  29.0,  28.0,  28.0,  27.0,  27.0,  26.0,  26.0,  25.0,  25.0,  24.0,  24.0,  23.0,  23.0,  22.0, 
 22.0,  22.0,  21.0,  21.0,  20.0,  20.0,  19.0,  19.0,  18.0,  18.0,  17.0,  17.0,  16.0,  16.0,  15.0,  15.0, 
 14.0,  14.0,  13.0,  13.0,  12.0,  12.0,  11.0,  11.0,  10.0,  10.0,   9.0,   9.0,   8.0,   8.0,   7.0,   7.0, 
  6.0,   6.0,   5.0,   5.0,   4.0,   4.0,   3.0,   3.0,   2.0,   2.0,   1.0,   1.0,   0.0,   0.0,  -1.0,  -1.0, 
 -2.0,  -2.0,  -3.0,  -4.0,  -4.0,  -5.0,  -6.0,  -6.0,  -7.0,  -7.0,  -8.0,  -9.0,  -9.0, -10.0, -11.0, -11.0, 
-12.0, -13.0, -14.0, -15.0, -16.0, -17.0, -18.0, -19.0, -20.0, -21.0, -22.0, -23.0, -24.0, -26.0, -27.0, -28.0, 
-29.0, -34.0, -35.0, -37.0, -39.0, -40.0, -42.0, -43.0, -45.0, -47.0, -48.0, -50.0, -52.0, -53.0, -55.0, -57.0, 
-55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, 
-55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0
 */

namespace IES_2.ECU
{
    class iaw04k : ecu
    {
        public const string name = "IAW-04K.P8";
        public const string longName = "Weber-Marelli IAW-04K.P8 MPI";
        public static string[,] cars = new string[,] {
                {"55BC83019429", "Alfa 155 2.0 16V 4x4"},
                {"55CE850894C4", "Dedra 2.0 16V"},
                {"55CE85079443", "Dedra 2.0 16V 4x4"},
                {"553883029426", "Tempra 2.0 8V 4x4"},
                {"553883019425", "Tempra 2.0 8V M/T"},
                {"5538830194A8", "Tempra 2.0 8V A/T"},
                {"55CB8202943B", "Dedra 2.0 8V A/T"},
                {"55CE8504943B", "Nuova Delta 2.0 T/C"},
                {"55CE85049440", "Nuova Delta 2.0"},
                {"55CB850194BA", "Coupe S 2.0 T/C"},
                {"55CE858394BF", "Coupe S 2.0"},
                {"55CD852613E0", "Delta Evoluzione 2000 16V 4x4"},
                {"55CB859B13D3", "Coupe ESSE 2.0 16V T/C"},
                {"55CB8592134A", "Nuova Delta 2.0 16V T/C 4x2"},
                {"55CE8501943D", "Nuova Delta 2.0 16V"},
                {"55D00292914A", "TIPO 2000 16V"},
                {"55CD850813C2", "Delta Evoluzione 2.0 16V ECO"}
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
        public override bool InitPasvDiag()
        {
            if (!sPort.IsOpen) return false;
            sPort.BaudRate = commBaud;
            return true;
        }
        public override string ReadISO()
        {
            if (!sPort.IsOpen) return null;
            byte[] ReqISO = new byte[] { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35 };
            byte[] ISOcod = new byte[6];
            byte buffer;
            byte i = 0;
            foreach (byte Request in ReqISO)
            {
                Thread.Sleep(5);
                if (!this.Query(Request, out buffer)) return null;
                if ((i == 0) & (buffer != 0x55)) // Sync byte error - probably IAW-16F
                {
                    ISO = null;
                    return null;
                }
                ISOcod[i++] = buffer;
            }
            ISO = "";
            foreach (byte b in ISOcod)
                ISO += b.ToString("X2");
            return ISO;
        }
        public override string ReadCODRIC()
        {
            if (!sPort.IsOpen) return null;
            byte[] ReqCodRic = new byte[] { 0x36, 0x37, 0x38, 0x39, 0x3A, 0x3B, 0x3C, 0x3D, 0x3E, 0x3F }; // CODRIC (Spare Part Code) request sequence
            byte[] CODRICcod = new byte[10];
            byte i = 0;
            foreach (byte Request in ReqCodRic)
            {
                Thread.Sleep(5);
                if (!this.Query(Request, out CODRICcod[i++])) return null;
            }
            CODRIC = "";
            foreach (char c in CODRICcod)
                CODRIC += c;
            return CODRIC;
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
            if (ISO.Substring(2, 4) == "BC83" || ISO.Substring(2, 4) == "CE85" || ISO.Substring(2, 4) == "3883" || ISO.Substring(2, 4) == "CB82" || ISO.Substring(2, 4) == "CB85" || ISO.Substring(2, 4) == "D002" || ISO.Substring(2, 4) == "3B83" || ISO.Substring(2, 4) == "CD85") return true;
            return false;
        }
        public static bool CheckCODRIC()
        {
            if (CODRIC == null) return false;
            if (CODRIC.Substring(0, 6) == "616000" || CODRIC.Substring(0, 6) == "616002") return true;
            return false;
        }
        public iaw04k(ref SerialPort sPort)
            : base(ref sPort)
        {
            engineData = new dataElement[] {
                new dataElement(lang.PERIODE, lang.rpm, "0", new byte[] { 0x01, 0x02 }, new dataElement.ValDecode(PERIODE)),
                new dataElement(lang.T_INJ_AP, "ms", "0.00", new byte[] { 0x03, 0x04 }, new dataElement.ValDecode(T_INJ_AP)),
                new dataElement(lang.AVANCE, "°", "0.00", new byte[] { 0x05 }, new dataElement.ValDecode(AVANCE)),
                new dataElement(lang.MP2_MP8, "hPa", "0", new byte[] { 0x06 }, new dataElement.ValDecode(MP2_MP8)),
                new dataElement(lang.MP2_MP8t, "hPa", "0", new byte[] { 0x06 }, new dataElement.ValDecode(MP2_MP8t)),
                new dataElement(lang.MT_AIR_L, "°C", "0.0", new byte[] { 0x07 }, new dataElement.ValDecode(MT_AIR_L)),
                new dataElement(lang.MT_EAU_L, "°C", "0.0", new byte[] { 0x08 }, new dataElement.ValDecode(MT_EAU_L)),
                new dataElement(lang.ANG_PAP0, "°", "0.00", new byte[] { 0x09 }, new dataElement.ValDecode(ANG_PAP0)),
                new dataElement(lang.V_BATT, "V", "0.00", new byte[] { 0x0A }, new dataElement.ValDecode(M_VBATT)),
                new dataElement(lang.ALFAR, lang.steps, "0", new byte[] { 0x0B }, new dataElement.ValDecode(ALFAR)),
                new dataElement(lang.TRIMRAM, lang.steps, "0", new byte[] { 0x19 }, new dataElement.ValDecode(TRIMRAM)),
                new dataElement(lang.INJ_AVA, "°", "0", new byte[] { 0x0C }, new dataElement.ValDecode(INJ_AVA)),
                new dataElement(lang.T_VAE, "%", "0", new byte[] { 0x0D }, new dataElement.ValDecode(T_VAE)),
                new dataElement(lang.K_O2, "", "0.00", new byte[] { 0x12, 0x13 }, new dataElement.ValDecode(K_O2)),
                new dataElement(lang.FLGSMA, "", lang.yes_no, new byte[] { 0x14 }, new dataElement.ValDecode(FLGSMA)),
                new dataElement(lang.FABEPAT, "", lang.yes_no, new byte[] { 0x1B }, new dataElement.ValDecode(FABEPAT)),
                new dataElement(lang.FABEEAT, "", lang.yes_no, new byte[] { 0x1C }, new dataElement.ValDecode(FABEEAT)),
                new dataElement(lang.FABEPATi, "", lang.yes_no, new byte[] { 0x1B }, new dataElement.ValDecode(FABEPATi)),
                new dataElement(lang.FABEEATi, "", lang.yes_no, new byte[] { 0x1C }, new dataElement.ValDecode(FABEEATi)),
                new dataElement(lang.StaAdvDecr, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR2)),
                new dataElement(lang.StaSigPanOK, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR3)),
                new dataElement(lang.StaThrMM, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR4)),
                new dataElement(lang.StaABSON, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR5)),
                new dataElement(lang.StaAirCoON, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR6)),
                new dataElement(lang.StaGearEng, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR7)), 
                new dataElement(lang.StaVAESC, "", lang.yes_no, new byte[] { 0x15 }, new dataElement.ValDecode(UR8))};
            activeTest = new testElement[] {
                new testElement( lang.FuelPump, false, 30, new byte[] { 0x80 }),
                new testElement( lang.Injectors, false, 5, new byte[] { 0x81 }),
                new testElement( lang.Injector1, false, 5, new byte[] { 0x8C }),
                new testElement( lang.Injector2, false, 5, new byte[] { 0x8D }),
                new testElement( lang.Injector3, false, 5, new byte[] { 0x8E }),
                new testElement( lang.Injector4, false, 5, new byte[] { 0x8F }),
                new testElement( lang.Coil1, false, 5, new byte[] { 0x82 }),
                new testElement( lang.Coil2, false, 5, new byte[] { 0x85 }),
                new testElement( lang.VAE, false, 5, new byte[] { 0x83 }),
                new testElement( lang.OverB, false, 5, new byte[] { 0x84 }),
                new testElement( lang.EVAP, false, 5, new byte[] { 0x90 }),
                new testElement( lang.REVmeter, false, 2, new byte[] { 0x89 }),
                new testElement( lang.ConMeter, false, 10, new byte[] { 0x88 }) };
            engineErrReq = new byte[] { 0x0F, 0x10, 0x11, 0x16, 0x17, 0x18, 0x1D, 0x1E, 0x1F };
            immoErrReq = new byte[] { };
            clearCodes = new testElement("", false, 10, new byte[] { 0x86 });
            engineErrors = new errorElement[] {
                new errorElement( lang.ErrVAE, 0x0F, 0x16, 0x1D, 0, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrMixRatio, 0x0F, 0x16, 0x1D, 1, 0x11, 0x18, 0x1F, 0, lang.MaxRICH, lang.MaxLEAN, new errorElement.ErrDecode(err04K)),
                new errorElement( lang.ErrIAT, 0x0F, 0x16, 0x1D, 2, 0x11, 0x18, 0x1F, 1, lang.OpenCircuit, lang.ShortToVcc, new errorElement.ErrDecode(err04K)),
                new errorElement( lang.ErrKnock, 0x0F, 0x16, 0x1D, 3, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)),
                new errorElement( lang.ErrECT, 0x0F, 0x16, 0x1D, 4, 0x11, 0x18, 0x1F, 2, lang.OpenCircuit, lang.ShortToVcc, new errorElement.ErrDecode(err04K)),
                new errorElement( lang.ErrLambda, 0x0F, 0x16, 0x1D, 5, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)),
                new errorElement( lang.ErrMAP, 0x0F, 0x16, 0x1D, 6, 0x11, 0x18, 0x1F, 7, lang.OpenCircuit, lang.ShortToVcc, new errorElement.ErrDecode(err04K)),
                new errorElement( lang.ErrTPS, 0x0F, 0x16, 0x1D, 7, 0x11, 0x18, 0x1F, 3, lang.OpenCircuit, lang.ShortToVcc, new errorElement.ErrDecode(err04K)),                
                new errorElement( lang.ErrCam, 0x10, 0x17, 0x1E, 0, 0x11, 0x18, 0x1F, 6, lang.OpenCircuit, lang.ShortToVcc, new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrSPS, 0x10, 0x17, 0x1E, 1, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrEPROM, 0x10, 0x17, 0x1E, 2, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrEEPROM, 0x10, 0x17, 0x1E, 3, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrNeutralGear, 0x10, 0x17, 0x1E, 4, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrDigimatic, 0x10, 0x17, 0x1E, 5, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrRAM, 0x10, 0x17, 0x1E, 6, 0, 0, 0, 0, "", "", new errorElement.ErrDecode(err04K)), 
                new errorElement( lang.ErrSMOT, 0x10, 0x17, 0x1E, 7, 0x11, 0x18, 0x1F, 5, lang.OpenCircuit, lang.ShortToVcc, new errorElement.ErrDecode(err04K))
            };
            immoErrors = new errorElement[] { };
            adjustments = new adjustElement[] { };
        }

        #region Live Data decoding functions
        private static decimal PERIODE() // Engine Speed
        {
            if ((Buffer[0x01] | Buffer[0x02]) == 0)
                return 0;
            else if ((Buffer[0x01] & Buffer[0x02]) == 255)
                return 0;
            else
                return (decimal)(30e+6 / unchecked(((ushort)Buffer[0x01]) << 8 | (ushort)Buffer[0x02]));
        }
        private static double[] ConvTab = { 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0,
                                            125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0, 125.0,
                                            125.0, 122.1, 119.2, 116.3, 113.4, 110.5, 107.6, 104.7, 101.8,  98.9,  96.0,  93.1,  90.2,  87.3,  84.4,  81.5,
                                             78.6,  77.4,  76.2,  75.0,  73.8,  72.5,  71.3,  70.1,  68.9,  67.7,  66.5,  65.3,  64.1,  62.8,  61.6,  60.4,
                                             59.2,  58.5,  57.7,  57.0,  56.3,  55.5,  54.8,  54.1,  53.4,  52.6,  51.9,  51.2,  50.4,  49.7,  49.0,  48.2,
                                             47.5,  46.9,  46.3,  45.7,  45.1,  44.5,  43.9,  43.3,  42.7,  42.1,  41.5,  40.9,  40.3,  39.7,  39.1,  38.5,
                                             37.9,  37.4,  36.9,  36.3,  35.8,  35.3,  34.8,  34.2,  33.7,  33.2,  32.7,  32.1,  31.6,  31.1,  30.6,  30.0,
                                             29.5,  29.0,  28.6,  28.1,  27.6,  27.2,  26.7,  26.2,  25.8,  25.3,  24.8,  24.3,  23.9,  23.4,  22.9,  22.5,
                                             22.0,  21.5,  21.0,  20.5,  20.0,  19.5,  19.0,  18.5,  18.0,  17.5,  17.0,  16.5,  16.0,  15.5,  15.0,  14.5,
                                             14.0,  13.5,  13.0,  12.5,  12.1,  11.6,  11.1,  10.6,  10.1,   9.6,   9.1,   8.6,   8.2,   7.7,   7.2,   6.7,
                                              6.2,   5.7,   5.2,   4.7,   4.2,   3.7,   3.2,   2.7,   2.2,   1.7,   1.2,   0.7,   0.2,  -0.3,  -0.8,  -1.3,
                                             -1.8,  -2.4,  -3.1,  -3.7,  -4.3,  -4.9,  -5.6,  -6.2,  -6.8,  -7.4,  -8.1,  -8.7,  -9.3,  -9.9, -10.6, -11.2,
                                            -11.8, -12.9, -13.9, -15.0, -16.0, -17.1, -18.1, -19.2, -20.3, -21.3, -22.4, -23.4, -24.5, -25.5, -26.6, -27.6,
                                            -28.7, -30.3, -32.0, -33.6, -35.3, -36.9, -38.6, -40.2, -41.9, -43.5, -45.1, -46.8, -48.4, -50.1, -51.7, -53.4,
                                            -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0,
                                            -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0, -55.0 };

        private static decimal T_INJ_AP() { return (decimal)(unchecked(((ushort)Buffer[0x03]) << 8 | (ushort)Buffer[0x04]) / 250.0); }// Injection Duration
        private static decimal AVANCE() { return (decimal)(Buffer[0x05] / 4.0); }// Ignition Advance
        private static decimal MP2_MP8() { return (decimal)(Buffer[0x06] * 3.8340 + 121.32); }// Manifold Absolute Pressure
        private static decimal MP2_MP8t() { return (decimal)(Buffer[0x06] * 8.5539 + 60.83); }// Manifold Absolute Pressure TURBO
        private static decimal MT_AIR_L() { return (decimal)(ConvTab[Buffer[0x07]]); }// Air Temperature
        private static decimal MT_EAU_L() { return (decimal)(ConvTab[Buffer[0x08]]); }// Water Temperature
        private static decimal ANG_PAP0() { return (decimal)(Buffer[0x09] < 171 ? Buffer[0x09] * 0.1848 - 1.41 : Buffer[0x09] * 0.7058 - 90.0); }// Throttle Angle P8
        private static decimal M_VBATT() { return (decimal)(Buffer[0x0A] * 0.0628); }// Battery Voltage
        private static decimal TRIMRAM() { return (decimal)(Buffer[0x19] - 128); }// Trimmer Position Adaptation
        private static decimal INJ_AVA() { return (decimal)(720 - Buffer[0x0C] * 90 / 4.0); }// Injection timing
        private static decimal T_VAE() { return (decimal)(Buffer[0x0D] * 100 / 255); }// VAE Duty Cycle
        private static decimal ALFAR() { return (decimal)(Buffer[0x0B] - 128); }// Idle stepper position
        private static decimal K_O2() { return (decimal)(unchecked(((ushort)Buffer[0x12]) << 8 | (ushort)Buffer[0x13]) / 8e+3); } //Lambda correction integrator
        private static decimal FLGSMA() { return (Buffer[0x14].GetBit(6)) ? 1 : 0; }
        private static decimal FABEPAT() { return (Buffer[0x1B].GetBit(6)) ? 1 : 0; }
        private static decimal FABEEAT() { return (Buffer[0x1C].GetBit(6)) ? 1 : 0; }
        private static decimal FABEPATi() { return (Buffer[0x1B].GetBit(5)) ? 1 : 0; }
        private static decimal FABEEATi() { return (Buffer[0x1C].GetBit(5)) ? 1 : 0; }
        private static decimal UR2() { return (Buffer[0x15].GetBit(1)) ? 1 : 0; }
        private static decimal UR3() { return (Buffer[0x15].GetBit(2)) ? 1 : 0; }
        private static decimal UR4() { return (Buffer[0x15].GetBit(3)) ? 1 : 0; }
        private static decimal UR5() { return (Buffer[0x15].GetBit(4)) ? 1 : 0; }
        private static decimal UR6() { return (Buffer[0x15].GetBit(5)) ? 1 : 0; }
        private static decimal UR7() { return (Buffer[0x15].GetBit(6)) ? 1 : 0; }
        private static decimal UR8() { return (Buffer[0x15].GetBit(7)) ? 1 : 0; }
        #endregion
        #region Errors decoding functions
        private errorState err04K(byte rAbase, byte rVbase, byte rSbase, byte oBase, byte rAext, byte rVext, byte rSext, byte oExt, string hExt, string lExt)
        {
            errorState result = new errorState();
            result.isActive = Buffer[rAbase].GetBit(oBase);
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
        #endregion
    }
}
