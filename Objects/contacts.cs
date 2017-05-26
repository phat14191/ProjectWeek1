using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    //variable
    private string _name;
    private string _phoneNumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact> {};

    //Constructor
    public Contact(string Name, string PhoneNumber, string Address)
    {
      _name = Name;
      _phoneNumber = PhoneNumber;
      _address = Address;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    //more commit .... //
    //static method//
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    //instance method//
    public void Save()
    {
      _instances.Add(this);
    }
    //ClearAll method//
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
