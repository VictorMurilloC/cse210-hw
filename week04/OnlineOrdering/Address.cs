public class Address {
    private string _street;
    
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    public bool IsUSA() {
        return _country == "USA";
    }

    public string WriteAll() {
        return _street + "\n, " + _city + ", " + _stateOrProvince + ", " + _country;
    } 
}