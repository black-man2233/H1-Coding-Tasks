namespace BankSystem.Model
{
    public class AddressModel
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string FullAdress { get; set; }

        public AddressModel(string _sM, int _sN, int _pC, string _c)
        {
            this.StreetName = _sM;
            this.StreetNumber = _sN;
            this.PostCode = _pC;
            this.City = _c;
            this.FullAdress = $"{_sM} {_sN}, {_pC} {_c}";
        }
        public AddressModel()
        {
            this.StreetName = "Gade";
            this.StreetNumber = 1;
            this.PostCode = 1000;
            this.City = "By";
            this.FullAdress = $"{this.StreetName} {this.StreetNumber}, {PostCode} {City}";
        }

        public string GetFullAddress() => $"{StreetName} {StreetNumber}, {PostCode} {City}"; //returns the full address

    }
}
