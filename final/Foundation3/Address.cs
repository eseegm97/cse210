class Address
{
    public string _street;
    public string _city;
    public string _stateOrProvince;
    public string _country;

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
}