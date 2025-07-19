class Address
{
    public string street;
    public string city;
    public string stateOrProvince;
    public string country;

    public string GetFullAddress()
    {
        return $"{street}, {city}, {stateOrProvince}, {country}";
    }
}