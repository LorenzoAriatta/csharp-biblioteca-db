using System;

public class User
{
	public string surname;

	public string name;

	public string email;

	public string password;

	public string phone;

	public bool isLogged;

	public User(string surname, string name, string email, string password, string phone)
    {
        this.surname = surname;

        this.name = name;

        this.email = email;

        this.password = password;

        this.phone = phone;

        this.isLogged = false;
    }

    public virtual void ToString()
    {
        Console.WriteLine($"Welcome {this.surname} {this.name}! \n Your info: \n email: {this.email} \n phone: {this.phone}");
    }
}
