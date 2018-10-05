namespace IES_2.ECU
{
    public struct dataElement
    {
        private string description;
        private string unit;
        private ValDecode valueCalc;
        private string format;
        private byte[] requestSet;

        public delegate decimal ValDecode();

        public decimal Value { get { return valueCalc(); } }
        public string FormattedValue { get { return Value.ToString(format); } }
        public byte[] RequestSet { get { return requestSet; } }
        public string Description { get { return description; } }
        public string Unit { get { return unit; } }

        public dataElement(string Description, string Unit, string Format, byte[] RequestSet, ValDecode ValueCalc)
        {
            description = Description;
            unit = Unit;
            requestSet = RequestSet;
            valueCalc = ValueCalc;
            format = Format;
        }
    }

    public struct testElement
    {
        private byte[] reqestSet;
        private byte timeOut;
        private bool engineRunnning;
        private string description;

        public string Description { get { return description; } }
        public bool EngineRunning { get { return engineRunnning; } }
        public byte TimeOut { get { return timeOut; } }
        public byte[] RequestSet { get { return reqestSet; } }

        public testElement(string Description, bool EngineRunnning, byte TimeOut, byte[] ReqestSet)
        {
            reqestSet = ReqestSet;
            timeOut = TimeOut;
            engineRunnning = EngineRunnning;
            description = Description;
        }
    }

    public struct adjustElement
    {
        private byte[] preSet;
        private byte[] postSet;
        private string description;
        private byte statusByte;
        private byte statusMask;
        private string type;

        public string Description { get { return description; } }
        public byte StatusByte { get { return statusByte; } }
        public byte StatusMask { get { return statusMask; } }
        public byte[] PreSet { get { return preSet; } }
        public byte[] PostSet { get { return postSet; } }
        public string Type { get { return type; } } // Valid types are: toggle, onebyte, code

        public adjustElement(string Description, byte StatusByte, byte StatusMask, byte[] PreSet, byte[] PostSet, string Type)
        {
            preSet = PreSet;
            postSet = PostSet;
            statusByte = StatusByte;
            statusMask = StatusMask;
            description = Description;
            type = Type;
        }
    }

    public struct errorElement
    {
        private string description;
        private errorState state;
        private ErrDecode decode;

        private byte rAbase;
        private byte rVbase;
        private byte rSbase;
        private byte rBase;
        private byte rAext;
        private byte rVext;
        private byte rSext;
        private byte rBext;
        private string hExt;
        private string lExt;

        public delegate errorState ErrDecode(byte rAbase, byte rVbase, byte rSbase, byte oBase, byte rAext, byte rVext, byte rSext, byte oExt, string hExt, string lExt);

        public string Description { get { return description; } }
        public bool isActive { get { return state.isActive; } }
        public bool isVerified { get { return state.isVerified; } }
        public bool isStored { get { return state.isStored; } }
        public string Reason { get { return state.Reason; } }
        public int Count { get { return state.Count; } }

        public void Decode()
        {
            state = decode(rAbase, rVbase, rSbase, rBase, rAext, rVext, rSext, rBext, hExt, lExt);
        }

        public errorElement(string Description, byte rAbase, byte rVbase, byte rSbase, byte oBase, byte rAext, byte rVext, byte rSext, byte oExt, string hExt, string lExt, ErrDecode Decode)
        {
            this.rAbase = rAbase;
            this.rVbase = rVbase;
            this.rSbase = rSbase;
            this.rBase = oBase;
            this.rAext = rAext;
            this.rVext = rVext;
            this.rSext = rSext;
            this.rBext = oExt;
            this.hExt = hExt;
            this.lExt = lExt;
            description = Description;
            decode = Decode;
            state = new errorState();
        }
    }

    public struct stateElement
    {
        private string description;
        private StaDecode decode;

        public delegate bool StaDecode();

        public string Description { get { return description; } }
        public bool Value { get { return decode(); } }

        public stateElement(string Description, StaDecode Decode)
        {
            description = Description;
            decode = Decode;
        }
    }

    public struct errorState
    {
        public bool isActive, isVerified, isStored;
        public byte Count;
        public string Reason;
    }

    public struct queryResult
    {
        public byte Request;
        public byte Response;
        public bool Success;
        public queryResult(byte req, byte resp, bool succ)
        {
            Request = req;
            Response = resp;
            Success = succ;
        }
    }
}
