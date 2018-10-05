using System.IO.Ports;
using IES_2.Res;

namespace IES_2.ECU
{
    class code : ecu
    {
        public const string name = "FIAT CODE";
        public const string longName = "FIAT CODE Immobiliser";
        public static string[,] cars = new string[,] {
                {"55D085859443", "Cinquecento 899 SPI ECE F2"},
                {"55D0858694C4", "Cinquecento 1108 SPI ECE F2"},
                {"55D0850194BF", "Punto 1.1 SPI Em.04 Est Europa"},
                {"55D085029440", "Punto 55 1.1 SPI 5M/6M ECE F2"},
                {"55D0850494C2", "Punto 60 1.2 SPI CM ECE F2 T.i.T."},
                {"55D085079445", "Punto Selecta 1.2 SPI ECE F2"},
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
                {"55D085139754", "Seicento 0.9 CM SPI F2"},
                {"55B683079126", "ALFA 33 1360 MPI CM"},
                {"55318002941C", "Punto 75 1.2 Fire 8V ECE F2"},
                {"5531808A1323", "Punto 75 1.2 Fire 8V ECE ECOL"},
                {"5531800E97AB", "Palio 1.2 Fire 8V ECE F2"},
                {"5531800794A1", "Delta/Dedra Bn/Sw 1.8 ECE F2"},
                {"55318083949D", "Alfa 145/146 1.3 Boxer ECE F2"},
                {"55318085941F", "Delta 1.8 90 CV ECE F2"},
                {"553180869420", "Tipo/Tempra Bn/Sw 1.8 ECE F2"},
                {"5531800D1629", "Punto 1242 FIRE 16V CEE F2"},
                {"5531808C16A8", "Siena 1.4 8V (IAW-1G7SP)"},
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
                {"55D00292914A", "TIPO 2000 16V"}
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
            return true;
        }
        public static bool CheckCODRIC()
        {
            return true;
        }
        public code(ref SerialPort sPort)
            : base(ref sPort)
        {
            engineData = new dataElement[] {
                new dataElement(lang.ErrCnt, "#", "0", new byte[] { 0x73 }, new dataElement.ValDecode(CRDVAS)) };
            activeTest = new testElement[] { };
            engineErrReq = new byte[] { };
            immoErrReq = new byte[] { 0x71, 0x72 };
            clearCodes = new testElement("", false, 10, new byte[] { 0x84 });
            engineErrors = new errorElement[] { };
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
            adjustments = new adjustElement[] { };
        }

        #region Live Data decoding functions
        private static decimal CRDVAS() { return Buffer[0x73]; }// CODE Error Counter
        #endregion
        #region Errors decoding functions
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
