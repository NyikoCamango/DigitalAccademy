// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;

//Creating method to insert values into employee database 
//INSERTING METHOD 
//
try{
    //creating our connection
    string sqlcon="";
    //creating a query 
       string query = "insert into employee(Empid,FirstName,LastName,Email,PhoneNumber,HomeAddress,GrossSalary)values'("+"');";
       //Creating an sql to pass our object through our connection to the database
    SqlConnection con = new SqlConnection(sqlcon);
      //
      MySqlCommand command = new MySqlCommand(query,con);
      //data gets read by our reader
      MySqlDataReader reader;
      //Opening our connection to read from the database 
      con.Open();

      //This is where our data will be read and inputted into the database 
      reader = command.ExecuteReader.ExecuteReader();
       while((reader.read)){
           
       }
   
      //Closing our connection to the database
     con.close();
}catch(Exception e ){
       
}

//Creating our method to edit
try{
     //Going to assign a connecion to my database
    string sqlcon="";
    //Creating our editing method 
    string query = "update employees set EmployeeID :'" + ;
    //creating my object to pass through connection string
    MySqlCommand command = new MySqlCommand(query,con);
      //data gets read by our reader
      MySqlDataReader reader;
      //Opening our connection to read from the database 
      con.Open();

      //This is where our data will be read and inputted into the database 
      reader = command.ExecuteReader.ExecuteReader();
       while((reader.read)){
           
       }
   
      //Closing our connection to the database
     con.close();

}catch(Exception e){
  

}

