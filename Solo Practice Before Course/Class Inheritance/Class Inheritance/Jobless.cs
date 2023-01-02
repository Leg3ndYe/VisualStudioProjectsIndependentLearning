namespace Class_Inheritance
{
    class Jobless : Human
    {
        public string Residence { get; set; }
        public string Reason { get; set; }
        public Jobless(BaseHumanInfo baseHumanInfo, string residence, string reason) : base(baseHumanInfo)
        {
            Residence = residence;
            Reason = reason;
        }
        public override string GetInfo()
        {
            string humanInfo = base.GetInfo();
            return humanInfo +
                $"\nResidance: {Residence}" +
                $"\nReason: {Reason}";
        }
    }
}
