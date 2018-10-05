using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using IES_2.Res;

// At 900 RPM a 4 cilinder 4 stroke engine makes 900 RPM * 2 strokes/revolution * 60 minutes in one hour = 108,000 strokes/hour.
// So if the ECU reads 480 mg/stroke at idle, it equals to 108,000 * 480e-6 = 52 kg/hour air flow.
// 480 mg/stroke is the value you should read with a 1.9L engine during idle when the EGR is closed.
// One full cilinder filling is 0.48 liter. Air is about 1290 mg per liter.
// So one could calculate 0.48 * 1290 = 619 mg/stroke.

namespace IES_2.ECU
{
    public abstract class ecu
    {
        public dataElement[] engineData;
        public testElement[] activeTest;
        public adjustElement[] adjustments;
        public errorElement[] engineErrors;
        public errorElement[] immoErrors;
        public testElement clearCodes;
        public byte[] engineErrReq;
        public byte[] immoErrReq;
        public bool hasIMMO;
        public abstract string GetCarModel();
        protected SerialPort sPort;

        //public static bool CheckISO() { return false; }
        //public static bool CheckCODRIC() { return false; }
        public static string ISO = null;
        public static string CODRIC = null;
        public const int initBaud = 1200; // Baud rate for init Diag. Mode
        public const int commBaud = 7680; // Baud rate for Diag. Mode
        public static bool connected = false;
        public static byte[] Buffer = new byte[255];
        public static bool[] Valid = new bool[255];
        //public const string name = null;
        //public const string longName = null;
        //public static string[,] cars;
        //public static string GetCars() { return ""; } 
        public static bool InitPasvDiag(ref SerialPort serial)
        {
            if (!serial.IsOpen) return false;
            serial.BaudRate = initBaud;
            serial.Write(new byte[] { 0x0F }, 0, 1);
            Thread.Sleep(110);
            serial.Write(new byte[] { 0xAA }, 0, 1);
            Thread.Sleep(110);
            serial.Write(new byte[] { 0xCC }, 0, 1);
            Thread.Sleep(150);
            while (serial.BytesToRead != 0)
                serial.ReadByte();
            serial.BaudRate = commBaud;
            return true;
        }
        public virtual bool InitPasvDiag()
        {
            if (!sPort.IsOpen) return false;
            sPort.BaudRate = initBaud;
            sPort.Write(new byte[] { 0x0F }, 0, 1);
            Thread.Sleep(110);
            sPort.Write(new byte[] { 0xAA }, 0, 1);
            Thread.Sleep(110);
            sPort.Write(new byte[] { 0xCC }, 0, 1);
            Thread.Sleep(150);
            while (sPort.BytesToRead != 0)
                sPort.ReadByte();
            sPort.BaudRate = commBaud;
            return true;
        }
        public static bool Query(ref SerialPort serial, byte qReq, out byte qResp)
        {
            serial.DiscardInBuffer();
            serial.Write(new byte[] { qReq }, 0, 1);
            try
            {
                serial.ReadByte();
                qResp = (byte)serial.ReadByte();
            }
            catch
            {
                qResp = 0;
                return false;
            }
            return true;
        }
        public bool Query(byte qReq, out byte qResp)
        {
            sPort.DiscardInBuffer();
            sPort.Write(new byte[] { qReq }, 0, 1);
            try
            {
                sPort.ReadByte(); //discard echo from interface
                qResp = (byte)sPort.ReadByte();
            }
            catch
            {
                qResp = 0;
                return false;
            }
            return true;
        }
        public static void SetReadTimeout(ref SerialPort serial, int time)
        {
            serial.ReadTimeout = time;
        }
        public static string ReadISO(ref SerialPort serial)
        {
            if (!serial.IsOpen) return null;
            byte[] ReqISO = new byte[] { 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F };
            byte[] ISOcod = new byte[6];
            byte buffer;
            byte i = 0;
            foreach (byte Request in ReqISO)
            {
                Thread.Sleep(5);
                if (!Query(ref serial, Request, out buffer)) return null;
                if ((i == 0) & (buffer != 0x55)) // Sync byte error - probably IAW-16F
                {
                    ISO = "55D085??????";
                    return ISO;
                }
                ISOcod[i++] = buffer;
            }
            ISO = "";
            foreach (byte b in ISOcod)
                ISO += b.ToString("X2");
            return ISO;
        }
        public static string ReadCODRIC(ref SerialPort serial)
        {
            if (!serial.IsOpen) return null;
            byte[] ReqCodRic = new byte[] { 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F, 0x20 }; // CODRIC (Spare Part Code) request sequence
            byte[] CODRICcod = new byte[10];
            byte i = 0;
            foreach (byte Request in ReqCodRic)
            {
                Thread.Sleep(5);
                if (!Query(ref serial, Request, out CODRICcod[i++])) return null;
            }
            CODRIC = "";
            foreach (char c in CODRICcod)
                CODRIC += c;
            return CODRIC;
        }
        public virtual string ReadISO()
        {
            return ReadISO(ref sPort);
        }
        public virtual string ReadCODRIC()
        {
            return ReadCODRIC(ref sPort);
        }
        //public virtual string ReadISO()
        //{
        //    if (!sPort.IsOpen) return null;
        //    byte[] ReqISO = new byte[] { 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F };
        //    byte[] ISOcod = new byte[6];
        //    byte buffer;
        //    byte i = 0;
        //    foreach (byte Request in ReqISO)
        //    {
        //        Thread.Sleep(5);
        //        if (!this.Query(Request, out buffer)) return null;
        //        if ((i == 0) & (buffer != 0x55)) // Sync byte error - probably IAW-16F
        //        {
        //            ISO = "55D085??????";
        //            return ISO;
        //        }
        //        ISOcod[i++] = buffer;
        //    }
        //    ISO = "";
        //    foreach (byte b in ISOcod)
        //        ISO += b.ToString("X2");
        //    return ISO;
        //}
        //public virtual string ReadCODRIC()
        //{
        //    if (!sPort.IsOpen) return null;
        //    byte[] ReqCodRic = new byte[] { 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F, 0x20 }; // CODRIC (Spare Part Code) request sequence
        //    byte[] CODRICcod = new byte[10];
        //    byte i = 0;
        //    foreach (byte Request in ReqCodRic)
        //    {
        //        Thread.Sleep(5);
        //        if (!this.Query(Request, out CODRICcod[i++])) return null;
        //    }
        //    CODRIC = "";
        //    foreach (char c in CODRICcod)
        //        CODRIC += c;
        //    return CODRIC;
        //}
        public static bool CheckCODE(ref SerialPort serial)
        {
            byte resp;
            return Query(ref serial, 0x71, out resp);
        }
        public ecu(ref SerialPort sPort)
        {
            this.sPort = sPort;
        }
    }

    //TODO: Query error counters when error is present
}