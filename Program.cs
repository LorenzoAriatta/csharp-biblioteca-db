// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



// Biblioteca online
// 1. registrati
// 2. login

//login 
// email: ..
// passowrd: ..

// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd

// Registrazione
// Scrivmi il nome: 
// scrivimi il cognome.. etc
// scrivi la passowrd: 

// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro

/*
UsersList users = new UsersList();
DocumentsList documents = new DocumentsList();
LendingsList lendings = new LendingsList();

users.UserRegistration("Calzoni", "Stefano", "stefano.calzoni@gmail.com", "lello123", "755445884");
users.UserRegistration("Filippini", "Fabio", "fabio.filippini@gmail.com", "lallo321", "755445885");
users.UserRegistration("Giovene", "Giovanni", "giovanni.giovene@gmail.com", "lillo213", "755445886");
*/

using System.Data.SqlClient;


MenuHome();



//functions
void MenuHome()
{
    Console.WriteLine("********************");
    Console.WriteLine("The Library");
    Console.WriteLine("********************");

    Console.WriteLine("1. Registrati");
    Console.WriteLine("2. Effettua login");
    int choice = Int32.Parse(Console.ReadLine());

    if (choice == 1)
    {
        RegisterMenu();
    }
    else if (choice == 2)
    {
        LoginMenu();
    }
}

void RegisterMenu()
{
    Console.Clear();

    Console.Write("Your name: ");
    string nameUser = Console.ReadLine();

    Console.Write("Your surname: ");
    string surnameUser = Console.ReadLine();

    Console.Write("Your email: ");
    string emailUser = Console.ReadLine();

    Console.Write("Your password: ");
    string passUser = Console.ReadLine();

    using (SqlConnection db_connect = new SqlConnection("Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True"))
    {
        try
        {
            db_connect.Open();

            string query = $"INSERT INTO users(@Name, @Username, @Password, @Mail) VALUES ({nameUser}, {surnameUser}, {emailUser}, {passUser});";

            using (SqlCommand cmd = db_connect.CreateCommand())
            using (SqlTransaction tran = db_connect.BeginTransaction("Register User"))
            {
                cmd.Connection = db_connect;
                cmd.Transaction = tran;
                try 
                {
                    //cmd.Parameters.Add(new SqlParameter("@Name", nameUser));
                    //cmd.Parameters.Add(new SqlParameter("@Surname", surnameUser));
                    //cmd.Parameters.Add(new SqlParameter("@Mail", emailUser));
                    //cmd.Parameters.Add(new SqlParameter("@Password", passUser));
                    cmd.CommandText = "INSERT INTO users (name, surname) VALUES (@Name, @Surname)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO users (mail, password) VALUE (@Mail, @Password)";
                    cmd.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            MenuHome();
        }
    }

    

    //users.UserRegistration(surname, name, email, password, phone);
}

void LoginMenu()
{
    Console.Clear();
    Console.WriteLine("Please, fill the fields: ");

    Console.Write("Email: ");
    string emailUser = Console.ReadLine();

    Console.Write("Password: ");
    string passUser = Console.ReadLine();

    using (SqlConnection db_connect = new SqlConnection("Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True"))
    {
        try
        {
            db_connect.Open();

            string query = "SELECT * FROM users WHERE mail=@Mail AND password=@Password;";

            using (SqlCommand cmd = new SqlCommand(query, db_connect))
            {
                cmd.Parameters.Add(new SqlParameter("@Mail", emailUser));
                cmd.Parameters.Add(new SqlParameter("@Password", passUser));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"Welcome back!");
                        Thread.Sleep(1000);
                        MenuHome();
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
            MenuHome();
        }
    }
}